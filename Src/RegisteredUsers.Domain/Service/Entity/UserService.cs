 using RegisteredUsers.Domain.Abstract.Repository.Entity.User;
using RegisteredUsers.Domain.Abstract.Service.Entity;
using RegisteredUsers.Domain.Entities.Entity;

namespace RegisteredUsers.Domain.Service.Entity
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public int IsAuthorise(string email, string password)
        {
            return this.userRepository.IsAuthorise(email, password);
        }
        public bool Registration(User user)
        {
            return this.userRepository.Registration(user);
        }
        public UserDetail GetUserDetailsById(int userId)
        {
            return this.userRepository.GetUserDetailsById(userId);  
        }

        public bool Update(UserDetail userDetaiils)
        {
            return this.userRepository.Update(userDetaiils);
        } 
    }
}
