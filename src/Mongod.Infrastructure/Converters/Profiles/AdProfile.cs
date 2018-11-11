using AutoMapper;
using Mongod.Domain.Entities;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.Converters.Profiles
{
    public class AdProfile : Profile
    {
        public AdProfile()
        {
            CreateMap<Ad,AdModel>();
            CreateMap<AdModel,Ad>();
        }
    }
}