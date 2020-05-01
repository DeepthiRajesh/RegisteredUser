using Microsoft.Extensions.Options;
using MongoDB.Driver;
using RegisteredUsers.DataAccess.Mongo.Mdo.User;

namespace RegisteredUsers.DataAccess.Mongo.Core
{
    public class MongoRepository
    {
        private readonly IMongoDatabase collection;

        public MongoRepository(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            collection = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<UserDocumentMdo> UserDocumentCollection => collection.GetCollection<UserDocumentMdo>("users");

        //public IMongoCollection<PersonalDetailDocumentMdo> PersonalDetailsDocumentCollection => collection.GetCollection<PersonalDetailDocumentMdo>("personal-details");
    }
}
