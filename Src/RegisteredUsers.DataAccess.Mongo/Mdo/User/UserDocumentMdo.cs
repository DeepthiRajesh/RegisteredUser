using MongoDB.Bson.Serialization.Attributes;
using RegisteredUsers.DataAccess.Mongo.Mdo.User.Internal;
using System;
using System.Runtime.Serialization;

namespace RegisteredUsers.DataAccess.Mongo.Mdo.User
{
    [BsonIgnoreExtraElements]
    public class UserDocumentMdo
    {
        [DataMember]
        [BsonIgnoreIfNull]
        public int UserId { get; set; }

        [DataMember]
        [BsonIgnoreIfNull]
        public string FirstName { get; set; }

        [DataMember]
        [BsonIgnoreIfNull]
        public string MiddleName { get; set; }

        [DataMember]
        [BsonIgnoreIfNull]
        public string LastName { get; set; }

        [DataMember]
        [BsonIgnoreIfNull]
        public string PhoneNumber { get; set; }

        [DataMember]
        [BsonIgnoreIfNull]
        public DateTime BirthDate { get; set; }

        [DataMember]
        [BsonIgnoreIfNull]
        public bool IsDeleted { get; set; }

        [DataMember]
        [BsonIgnoreIfNull]
        public PersonalDetailDocumentMdo PersonalDetails { get; set; }

    }
}
