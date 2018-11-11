using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Mongod.Domain.Entities;
using Mongod.Domain.Repositories;
using Mongod.Domain.Repositories.Interfaces;
using Mongod.Infrastructure.Converters;
using Mongod.Infrastructure.Converters.Interfaces;
using Mongod.Infrastructure.Models;
using Mongod.Infrastructure.Services;
using Mongod.Infrastructure.Services.Interfaces;
using Mongod.Infrastructure.Validators;
using MongoDB.Driver;

namespace Mongod.Extensions
{
    public static class StartupExtensions
    {
        public static IServiceCollection RegisterDatabase(this IServiceCollection services, string connectionString)
        {
            services.AddSingleton<IMongoClient>(new MongoClient(connectionString));

            services.AddScoped<IBaseRepository<Flat>,BaseRepository<Flat>>();

            return services;
        }

        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddAutoMapper();

            services.AddScoped<IValidator<FlatModel>,FlatValidator>();
            services.AddScoped<IValidator<UserModel>,UserValidator>();
            services.AddScoped<IValidator<AddressModel>,AddressValidator>();

            services.AddScoped<IConverter<Flat,FlatModel>,FlatConverter>();
            
            services.AddScoped<IService<FlatModel, Flat>,Service<FlatModel, Flat>>();
            return services;
        }
    }
}