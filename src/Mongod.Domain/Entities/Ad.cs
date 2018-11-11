using Mongod.Domain.Attributes;
using MongoDB.Bson.Serialization.Attributes;

namespace Mongod.Domain.Entities
{
    [BsonCollection("ads")]
    public class Ad : BaseEntity
    {
        [BsonElement("owner")]
        public User Owner { get; set; }

        [BsonElement("address")]
        public Address Address { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }
    }
}