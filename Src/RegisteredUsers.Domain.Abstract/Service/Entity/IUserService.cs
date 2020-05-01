
using RegisteredUsers.Domain.Entities.Entity;

namespace RegisteredUsers.Domain.Abstract.Service.Entity
{
    public interface IUserService
    {
        bool Registration(User user);
        int IsAuthorise(string email, string password);
        UserDetail GetUserDetailsById(int userId);
        bool Update(UserDetail userDetaiils);
    } 
}
