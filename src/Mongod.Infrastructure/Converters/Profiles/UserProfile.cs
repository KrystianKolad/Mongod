using AutoMapper;
using Mongod.Domain.Entities;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.Converters.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User,UserModel>();
            CreateMap<UserModel,User>();
        }
    }
}