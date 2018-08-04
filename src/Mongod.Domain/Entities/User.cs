using System;
using Mongod.Domain.Attributes;
using MongoDB.Bson.Serialization.Attributes;

namespace Mongod.Domain.Entities
{
    [BsonCollection("Users")]
    public class User : BaseEntity
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("surname")]
        public string Surname { get; set; }
    }
}