using Mongod.Domain.Attributes;
using MongoDB.Bson.Serialization.Attributes;

namespace Mongod.Domain.Entities
{
    [BsonCollection("Flats")]
    public class Flat : BaseEntity
    {
        [BsonElement("owner")]
        public User Owner { get; set; }

        [BsonElement("address")]
        public Address Address { get; set; }

        [BsonElement("roomscount")]
        public int RoomsCount { get; set; }
    }
}