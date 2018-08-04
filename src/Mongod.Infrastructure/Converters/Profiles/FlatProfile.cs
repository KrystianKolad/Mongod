using AutoMapper;
using Mongod.Domain.Entities;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.Converters.Profiles
{
    public class FlatProfile : Profile
    {
        public FlatProfile()
        {
            CreateMap<Flat,FlatModel>();
            CreateMap<FlatModel,Flat>()
                .ForMember(x=>x.Id, y=>y.Ignore());
        }
    }
}