using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mongod.Domain.Entities;
using Mongod.Infrastructure.Models;
using Mongod.Infrastructure.ViewModels;

namespace Mongod.Infrastructure.Services.Interfaces
{
    public interface IService<TModel, TEntity> 
        where TEntity : BaseEntity
        where TModel : BaseModel
    {
        Task AddAsync(TModel model);
        Task<TModel> FindAsync(Guid id);
        Task<PageViewModel<TModel>> GetPageAsync(int pageNumber, int maxPageItemsCount);
    }
}