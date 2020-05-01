using Microsoft.AspNetCore.Mvc;
using RegisteredUsers.Domain.Abstract.Service.Entity;
using RegisteredUsers.Presentation.UI.Controllers.API.Helpers;
using RegisteredUsers.Presentation.UI.ViewModel;
using System;
using System.Net;

namespace RegisteredUsers.Presentation.UI.Controllers.API
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost("registration")]
        public IActionResult Registraion([FromBody] UserViewModel model)
        {
            try
            {
                return Ok(this.userService.Registration(model.ToUserDomain()));
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException(ex.Message);
            }
        }

        [HttpPost("login")]
        public IActionResult IsAuthorise([FromBody] LoginViewModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Email) || string.IsNullOrWhiteSpace(model.Password))
            {
                return BadRequest("Username and Password can not be null.");
            }
            try
            {
                return Ok(this.userService.IsAuthorise(model.Email, model.Password));
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException(ex.Message);
            }
        }

        [HttpGet("{userId}")]
        public IActionResult GetUserDetailsById([FromRoute] int userId)
        {
            if (userId <= 0)
            {
                return Ok(HttpStatusCode.BadRequest);
            }
            try
            {
                var result = this.userService.GetUserDetailsById(userId);

                return Ok(result.ToUserDetailViewModel());
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException(ex.Message);
            }
        }

        [HttpPost("update")]
        public IActionResult Update([FromBody] UserDetailViewModel userModel)
        {
            try
            {
                return Ok(this.userService.Update(userModel.ToUpdateUserDomain()));
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException(ex.Message);
            }
        }
    }
}
