using System.Collections.Generic;
using Mongod.Domain.Entities;
using Mongod.Infrastructure.Converters.Interfaces;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.Converters
{
    public class FlatConverter : IConverter<Flat, FlatModel>
    {
        public Flat Convert(FlatModel model)
        {
            throw new System.NotImplementedException();
        }

        public FlatModel Convert(Flat entity)
        {
            throw new System.NotImplementedException();
        }

        public IList<FlatModel> Convert(IList<Flat> entity)
        {
            throw new System.NotImplementedException();
        }

        public IList<Flat> Convert(IList<FlatModel> entity)
        {
            throw new System.NotImplementedException();
        }
    }
}