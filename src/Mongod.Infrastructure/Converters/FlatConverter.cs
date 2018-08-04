using System.Collections.Generic;
using AutoMapper;
using Mongod.Domain.Entities;
using Mongod.Infrastructure.Converters.Interfaces;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.Converters
{
    public class FlatConverter : IConverter<Flat, FlatModel>
    {
        private IMapper _mapper;
        public FlatConverter(IMapper mapper)
        {
            _mapper = mapper;
        }
        public Flat Convert(FlatModel model)
        {
            return _mapper.Map<FlatModel,Flat>(model);
        }

        public FlatModel Convert(Flat entity)
        {
            return _mapper.Map<Flat,FlatModel>(entity);
        }

        public IList<FlatModel> Convert(List<Flat> entity)
        {
            return _mapper.Map<List<Flat>,List<FlatModel>>(entity);
        }

        public IList<Flat> Convert(List<FlatModel> entity)
        {
            return _mapper.Map<List<FlatModel>,List<Flat>>(entity);
        }
    }
}