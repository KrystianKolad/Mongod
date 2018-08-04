using System.Collections.Generic;
using AutoMapper;
using Mongod.Domain.Entities;
using Mongod.Infrastructure.Converters.Interfaces;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.Converters
{
    public class AddressConverter : IConverter<Address, AddressModel>
    {
        private IMapper _mapper;
        public AddressConverter(IMapper mapper)
        {
            _mapper = mapper;
        }
        public Address Convert(AddressModel model)
        {
            return _mapper.Map<AddressModel,Address>(model);
        }

        public AddressModel Convert(Address entity)
        {
            return _mapper.Map<Address,AddressModel>(entity);
        }

        public IList<AddressModel> Convert(List<Address> entity)
        {
            return _mapper.Map<List<Address>,List<AddressModel>>(entity);
        }

        public IList<Address> Convert(List<AddressModel> entity)
        {
            return _mapper.Map<List<AddressModel>,List<Address>>(entity);
        }
    }
}