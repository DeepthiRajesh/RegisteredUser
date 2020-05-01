using RegisteredUsers.Domain.Entities.Document;
using System.Threading.Tasks;

namespace RegisteredUsers.Domain.Abstract.Service.Document
{
    public interface IUserService
    {
        Task<UserDetailDocument> GetUserDetailsById(int userId);

        Task<bool> Replicate(UserDetailDocument user);

    }
}
