using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mongod.Domain.Entities;

namespace Mongod.Infrastructure.Services.Interfaces
{
    public interface IService<TModel, TEntity> 
        where TEntity : BaseEntity
        where TModel : class
    {
        Task AddAsync(TModel model);
        Task<TModel> FindAsync(Guid id);
        Task<IList<TModel>> GetAllAsync();
    }
}