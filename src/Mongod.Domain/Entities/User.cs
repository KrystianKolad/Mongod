using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Mongod.Domain.Entities
{
    public class User : BaseEntity
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("surname")]
        public string Surname { get; set; }
    }
}