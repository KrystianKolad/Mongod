using System.Collections.Generic;
using AutoMapper;
using Mongod.Domain.Entities;
using Mongod.Infrastructure.Converters.Interfaces;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.Converters
{
    public class AdConverter : IConverter<Ad, AdModel>
    {
        private IMapper _mapper;
        public AdConverter(IMapper mapper)
        {
            _mapper = mapper;
        }
        public Ad Convert(AdModel model)
        {
            return _mapper.Map<AdModel,Ad>(model);
        }

        public AdModel Convert(Ad entity)
        {
            return _mapper.Map<Ad,AdModel>(entity);
        }

        public IList<AdModel> Convert(List<Ad> entity)
        {
            return _mapper.Map<List<Ad>,List<AdModel>>(entity);
        }

        public IList<Ad> Convert(List<AdModel> entity)
        {
            return _mapper.Map<List<AdModel>,List<Ad>>(entity);
        }
    }
}