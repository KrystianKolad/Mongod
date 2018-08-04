using System.Collections.Generic;
using AutoMapper;
using Mongod.Domain.Entities;
using Mongod.Infrastructure.Converters.Interfaces;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.Converters
{
    public class UserConverter : IConverter<User, UserModel>
    {
        private IMapper _mapper;
        public UserConverter(IMapper mapper)
        {
            _mapper = mapper;
        }
        public User Convert(UserModel model)
        {
            return _mapper.Map<UserModel,User>(model);
        }

        public UserModel Convert(User entity)
        {
            return _mapper.Map<User,UserModel>(entity);
        }

        public IList<UserModel> Convert(List<User> entity)
        {
            return _mapper.Map<List<User>,List<UserModel>>(entity);
        }

        public IList<User> Convert(List<UserModel> entity)
        {
            
            return _mapper.Map<List<UserModel>,List<User>>(entity);
        }
    }
}