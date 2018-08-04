using System.Collections.Generic;
using Mongod.Domain.Entities;
using Mongod.Infrastructure.Converters.Interfaces;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.Converters
{
    public class AddressConverter : IConverter<Address, AddressModel>
    {
        public Address Convert(AddressModel model)
        {
            throw new System.NotImplementedException();
        }

        public AddressModel Convert(Address entity)
        {
            throw new System.NotImplementedException();
        }

        public IList<AddressModel> Convert(IList<Address> entity)
        {
            throw new System.NotImplementedException();
        }

        public IList<Address> Convert(IList<AddressModel> entity)
        {
            throw new System.NotImplementedException();
        }
    }
}