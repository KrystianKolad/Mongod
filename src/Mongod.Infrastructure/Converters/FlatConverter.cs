using System.Collections.Generic;
using AutoMapper;
using Mongod.Domain.Entities;
using Mongod.Infrastructure.Converters.Interfaces;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.Converters
{
    public class FlatConverter : IConverter<Flat, FlatModel>
    {
        public Flat Convert(FlatModel model)
        {
            return Mapper.Map<FlatModel,Flat>(model);
        }

        public FlatModel Convert(Flat entity)
        {
            return Mapper.Map<Flat,FlatModel>(entity);
        }

        public IList<FlatModel> Convert(List<Flat> entity)
        {
            return Mapper.Map<List<Flat>,List<FlatModel>>(entity);
        }

        public IList<Flat> Convert(List<FlatModel> entity)
        {
            return Mapper.Map<List<FlatModel>,List<Flat>>(entity);
        }
    }
}