using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mongod.Domain.Entities;

namespace Mongod.Domain.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task Add(T entity);
        Task<T> Find(Guid id);
        Task<IList<T>> GetAll();
    }
}