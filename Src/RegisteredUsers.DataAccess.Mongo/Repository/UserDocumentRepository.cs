using Microsoft.Extensions.Options;
using MongoDB.Driver;
using RegisteredUsers.DataAccess.Mongo.Core;
using RegisteredUsers.DataAccess.Mongo.Helpers;
using RegisteredUsers.DataAccess.Mongo.Mdo.User;
using RegisteredUsers.DataAccess.Mongo.Mdo.User.Internal;
using RegisteredUsers.Domain.Abstract.Repository.Document;
using RegisteredUsers.Domain.Entities.Document;
using System.Linq;
using System.Threading.Tasks;

namespace RegisteredUsers.DataAccess.Mongo.Repository
{
    public class UserDocumentRepository : MongoRepository, IUserDocumentRepository
    {
        public UserDocumentRepository(IOptions<Settings> configSettings) :
       base(configSettings)
        {

        }
        public async Task<UserDetailDocument> GetUserDetailsByIdAsync(int userId)
        {

            var findOptions = this.GetIncludedFields();
            var filter = Builders<UserDocumentMdo>.Filter.Where(x => x.UserId == userId);

            var result = await this.UserDocumentCollection.FindAsync(filter, findOptions);

            return result?.ToList()?.Select(d => d.ToUserDocument()).FirstOrDefault();
        }

        public async Task<bool> Replicate(UserDetailDocument document)
        {
            var filter = Builders<UserDocumentMdo>.Filter.Where(s => s.UserId == document.UserId);

            var update = Builders<UserDocumentMdo>.Update
                        .Set(s => s.FirstName, document.FirstName)
                        .Set(s => s.MiddleName, document.MiddleName)
                        .Set(s => s.LastName, document.LastName)
                        .Set(s => s.BirthDate, document.BirthDate)
                        .Set(s => s.IsDeleted, document.IsDeleted)
                        .Set(s => s.PhoneNumber, document.PhoneNumber)
                        .Set(s => s.UserId, document.UserId)
                        .Set(s => s.PersonalDetails, new PersonalDetailDocumentMdo
                        { Address= document.Address,
                          City = document.City, 
                          State = document.State,
                          Pincode = document.Pincode,
                          Country = document.Country,
                          Qualification = document.Qualification,
                          JobTitle = document.JobTitle,
                          Photo = document.Photo
                        });

            var result = await this.UserDocumentCollection.UpdateOneAsync(filter, update, new UpdateOptions { IsUpsert = true });
            return result.IsAcknowledged;
        }

        private FindOptions<UserDocumentMdo, UserDocumentMdo> GetIncludedFields()
        {
            return new FindOptions<UserDocumentMdo, UserDocumentMdo>
            {
                Projection = Builders<UserDocumentMdo>.Projection
                            .Include(x => x.UserId)
                            .Include(x => x.FirstName)
                            .Include(x => x.LastName)
                            .Include(s => s.MiddleName)
                            .Include(s => s.PhoneNumber)
                            .Include(s => s.PersonalDetails)


            };
        }

    }
}
