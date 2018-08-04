using AutoMapper;
using Mongod.Domain.Entities;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.Converters.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address,AddressModel>();
            CreateMap<AddressModel, Address>()
                .ForMember(x=>x.Id, y=>y.Ignore());
        }
    }
}