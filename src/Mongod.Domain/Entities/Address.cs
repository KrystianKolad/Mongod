using MongoDB.Bson.Serialization.Attributes;

namespace Mongod.Domain.Entities
{
    public class Address : BaseEntity
    {
        [BsonElement("zipcode")]
        public string ZipCode { get; set; }

        [BsonElement("street")]
        public string Street { get; set; }

        [BsonElement("city")]
        public string City { get; set; }

        [BsonElement("buildingnumber")]
        public int BuildingNumber { get; set; }

        [BsonElement("FlatNumber")]
        public int FlatNumber { get; set; }
    }
}