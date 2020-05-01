using Blockfire.Data.Mongo.Core;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.Serialization;

namespace RegisteredUsers.DataAccess.Mongo.Mdo.User.Internal
{
    [BsonIgnoreExtraElements]
    public class PersonalDetailDocumentMdo : BaseDocument
    {
        [DataMember]
        [BsonIgnoreIfNull]
        public int PersonalDetailId { get; set; }

        [DataMember]
        [BsonIgnoreIfNull]
        public int UserId { get; set; }

        [DataMember]
        [BsonIgnoreIfNull]
        public string Address { get; set; }

        [DataMember]
        [BsonIgnoreIfNull]
        public string City { get; set; }

        [DataMember]
        [BsonIgnoreIfNull]
        public string State { get; set; }

        [DataMember]
        [BsonIgnoreIfNull]
        public string Pincode { get; set; }

        [DataMember]
        [BsonIgnoreIfNull]
        public string Country { get; set; }

        [DataMember]
        [BsonIgnoreIfNull]
        public string Qualification { get; set; }

        [DataMember]
        [BsonIgnoreIfNull]
        public string JobTitle { get; set; }

        [DataMember]
        [BsonIgnoreIfNull]
        public string Photo { get; set; }

        [DataMember]
        [BsonIgnoreIfNull]
        public bool IsDeleted { get; set; }
    }
}
