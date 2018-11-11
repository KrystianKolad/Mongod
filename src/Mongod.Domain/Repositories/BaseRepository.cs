using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mongod.Domain.Attributes;
using Mongod.Domain.Consts;
using Mongod.Domain.Entities;
using Mongod.Domain.Repositories.Interfaces;
using MongoDB.Driver;

namespace Mongod.Domain.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly IMongoDatabase _database;
        public BaseRepository(IMongoClient mongoClient)
        {
            _database = mongoClient.GetDatabase(MongoConsts.MongoDatabaseName);
        }
        public async Task AddAsync(T entity)
        {
            var collection = _database.GetCollection<T>(GetCollectionName());
            await collection.InsertOneAsync(entity);
        }

        public async Task<T> FindAsync(Guid id)
        {
            var collection = _database.GetCollection<T>(GetCollectionName());
            return await collection.Find(x=>x.Id.Equals(id)).SingleOrDefaultAsync();
        }

        public async Task<List<T>> GetPage(int pageNumber, int maxPageItemsCount)
        {
            var collection = _database.GetCollection<T>(GetCollectionName());
            return await collection
                .Find(FilterDefinition<T>.Empty)
                .Skip(pageNumber*maxPageItemsCount)
                .Limit(maxPageItemsCount+1)
                .ToListAsync();
        }

        private string GetCollectionName()
        {
            return (typeof(T).GetCustomAttributes(typeof(BsonCollectionAttribute), true).FirstOrDefault()
                as BsonCollectionAttribute).CollectionName;
        }
    }
}