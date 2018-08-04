using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
            _database = mongoClient.GetDatabase("mongod");
        }
        public Task Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> Find(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}