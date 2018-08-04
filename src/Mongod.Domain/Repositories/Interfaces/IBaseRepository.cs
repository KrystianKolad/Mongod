using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mongod.Domain.Entities;

namespace Mongod.Domain.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task AddAsync(T entity);
        Task<T> FindAsync(Guid id);
        Task<List<T>> GetAllAsync();
    }
}