using System.Collections.Generic;
using Mongod.Domain.Entities;
using Mongod.Infrastructure.Converters.Interfaces;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.Converters
{
    public class UserConverter : IConverter<User, UserModel>
    {
        public User Convert(UserModel model)
        {
            throw new System.NotImplementedException();
        }

        public UserModel Convert(User entity)
        {
            throw new System.NotImplementedException();
        }

        public IList<UserModel> Convert(IList<User> entity)
        {
            throw new System.NotImplementedException();
        }

        public IList<User> Convert(IList<UserModel> entity)
        {
            throw new System.NotImplementedException();
        }
    }
}