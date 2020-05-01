using Microsoft.AspNetCore.Mvc;
using RegisteredUsers.Presentation.API.Controllers.Helpers;
using System;
using System.Net;

namespace RegisteredUsers.Presentation.API.Controllers
{
    [Route("api/v1/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly Domain.Abstract.Service.Document.IUserService userDocumentService;
        private readonly Domain.Abstract.Service.Entity.IUserService userService;

        public UserController(Domain.Abstract.Service.Document.IUserService userDocumentService,
                              Domain.Abstract.Service.Entity.IUserService userService)
        {
            this.userDocumentService = userDocumentService;
            this.userService = userService;
        }

        [HttpGet("{userId}")]
        public async System.Threading.Tasks.Task<IActionResult> GetUserDetailsByIdAsync([FromRoute] int userId)
        {
            if (userId <= 0)
            {
                return Ok(HttpStatusCode.BadRequest);
            }
            try
            {
                var result = await this.userDocumentService.GetUserDetailsById(userId);

                return Ok(result.ToUserDetailViewModel());
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException(ex.Message);
            }
        }

        [HttpPost("replicate({userId})")]
        public async System.Threading.Tasks.Task<IActionResult> ReplicateAsync([FromRoute] int userId)
        {
            if (userId <= 0)
            {
                return Ok(HttpStatusCode.BadRequest);
            }
            try
            {
                var user = this.userService.GetUserDetailsById(userId);
                var result = await this.userDocumentService.Replicate(user.ToUserDetailDocument());

                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException(ex.Message);
            }
        }

        [HttpPost("replicate")]
        public IActionResult ReplicateAll()
        {
            try
            {
                var result = true;// this.userDocumentService.ReplicateAll();

                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException(ex.Message);
            }
        }
    }
}