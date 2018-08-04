using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mongod.Domain.Entities;
using Mongod.Domain.Repositories.Interfaces;
using Mongod.Infrastructure.Converters.Interfaces;
using Mongod.Infrastructure.Models;
using Mongod.Infrastructure.Services.Interfaces;

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

        public async Task<IList<TModel>> GetAllAsync()
        {
            return _converter.Convert(await _repository.GetAllAsync());
        }
    }
}