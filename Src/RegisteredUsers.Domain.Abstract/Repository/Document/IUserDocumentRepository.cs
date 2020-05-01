using RegisteredUsers.Domain.Entities.Document;
using System.Threading.Tasks;

namespace RegisteredUsers.Domain.Abstract.Repository.Document
{
    public interface IUserDocumentRepository
    {
        Task<UserDetailDocument> GetUserDetailsByIdAsync(int userId);

        Task<bool> Replicate(UserDetailDocument user);

    }
}
