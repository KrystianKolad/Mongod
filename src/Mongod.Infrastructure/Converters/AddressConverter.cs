using System.Collections.Generic;
using AutoMapper;
using Mongod.Domain.Entities;
using Mongod.Infrastructure.Converters.Interfaces;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.Converters
{
    public class AddressConverter : IConverter<Address, AddressModel>
    {
        public Address Convert(AddressModel model)
        {
            return Mapper.Map<AddressModel,Address>(model);
        }

        public AddressModel Convert(Address entity)
        {
            return Mapper.Map<Address,AddressModel>(entity);
        }

        public IList<AddressModel> Convert(List<Address> entity)
        {
            return Mapper.Map<List<Address>,List<AddressModel>>(entity);
        }

        public IList<Address> Convert(List<AddressModel> entity)
        {
            return Mapper.Map<List<AddressModel>,List<Address>>(entity);
        }
    }
}