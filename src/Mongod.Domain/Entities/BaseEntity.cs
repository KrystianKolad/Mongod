using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Mongod.Domain.Entities
{
    public class BaseEntity
    {
        [BsonId]
        [BsonElement("id")]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; }
    }
}