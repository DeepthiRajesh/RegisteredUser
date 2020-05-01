using RegisteredUsers.Domain.Entities.Entity;

namespace RegisteredUsers.Domain.Abstract.Repository.Entity.User
{
    public interface IUserRepository
    {
        bool Registration(Entities.Entity.User user);
        int IsAuthorise(string email, string password);
        Entities.Entity.UserDetail GetUserDetailsById(int userId);
        bool Update(UserDetail userDetails);
    }
}
 