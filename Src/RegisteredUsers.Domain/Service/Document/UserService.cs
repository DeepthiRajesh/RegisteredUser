using RegisteredUsers.Domain.Abstract.Repository.Document;
using RegisteredUsers.Domain.Abstract.Service.Document;
using RegisteredUsers.Domain.Entities.Document;
using System.Threading.Tasks;

namespace RegisteredUsers.Domain.Service.Document
{
    public class UserService : IUserService
    {
        private readonly IUserDocumentRepository userRepository;

        public UserService(IUserDocumentRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<UserDetailDocument> GetUserDetailsById(int userId)
        {
            return await this.userRepository.GetUserDetailsByIdAsync(userId);
        }

        public async Task<bool> Replicate(UserDetailDocument user)
        {
            return await this.userRepository.Replicate(user);
        }

    }
}
