using System.Collections.Generic;
using AutoMapper;
using Mongod.Domain.Entities;
using Mongod.Infrastructure.Converters.Interfaces;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.Converters
{
    public class UserConverter : IConverter<User, UserModel>
    {
        public User Convert(UserModel model)
        {
            return Mapper.Map<UserModel,User>(model);
        }

        public UserModel Convert(User entity)
        {
            return Mapper.Map<User,UserModel>(entity);
        }

        public IList<UserModel> Convert(List<User> entity)
        {
            return Mapper.Map<List<User>,List<UserModel>>(entity);
        }

        public IList<User> Convert(List<UserModel> entity)
        {
            
            return Mapper.Map<List<UserModel>,List<User>>(entity);
        }
    }
}