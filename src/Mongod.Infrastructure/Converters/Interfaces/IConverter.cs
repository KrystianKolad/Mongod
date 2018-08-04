using System.Collections.Generic;
using Mongod.Domain.Entities;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.Converters.Interfaces
{
    public interface IConverter<TEntity, TModel>
        where TEntity : BaseEntity
        where TModel : BaseModel
    {
        TEntity Convert(TModel model);
        TModel Convert(TEntity entity);
        IList<TModel> Convert(IList<TEntity> entity);
        IList<TEntity> Convert(IList<TModel> entity);
    }
}