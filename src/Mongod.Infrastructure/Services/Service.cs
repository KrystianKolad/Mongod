using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mongod.Domain.Entities;
using Mongod.Domain.Repositories.Interfaces;
using Mongod.Infrastructure.Converters.Interfaces;
using Mongod.Infrastructure.Models;
using Mongod.Infrastructure.Services.Interfaces;
using Mongod.Infrastructure.ViewModels;

namespace Mongod.Infrastructure.Services
{
    public class Service<TModel, TEntity> : IService<TModel, TEntity>
        where TModel : BaseModel
        where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _repository;
        private readonly  IConverter<TEntity,TModel> _converter;
        public Service(IBaseRepository<TEntity> repository, IConverter<TEntity,TModel> converter)
        {
            _repository = repository;
            _converter = converter;
        }
        public async Task AddAsync(TModel model)
        {
            TEntity entity = _converter.Convert(model);
            await _repository.AddAsync(entity);
        }

        public async Task<TModel> FindAsync(Guid id)
        {
            return _converter.Convert(await _repository.FindAsync(id));
        }

        public async Task<PageViewModel<TModel>> GetPageAsync(int pageNumber, int maxPageItemsCount)
        {
            var items = _converter.Convert(await _repository.GetPage(pageNumber,maxPageItemsCount));

            return new PageViewModel<TModel>()
            {
                Items = items.Take(maxPageItemsCount).ToList(),
                PageNumber = pageNumber,
                MaxPageItemsCount = maxPageItemsCount,
                NexPageAvailable = items.Count() > maxPageItemsCount
            };
        }
    }
}