using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Runtime.Serialization;

namespace Blockfire.Data.Mongo.Core
{

    [DataContract]
    [Serializable]
    [BsonIgnoreExtraElements(Inherited = true)]
    public class BaseDocument
    {
        [DataMember]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfDefault]
        public virtual string Id { get; set; }

    }
}
