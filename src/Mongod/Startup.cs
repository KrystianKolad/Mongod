using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mongod.Domain.Entities;
using Mongod.Domain.Repositories;
using Mongod.Domain.Repositories.Interfaces;
using Mongod.Infrastructure.Converters;
using Mongod.Infrastructure.Converters.Interfaces;
using Mongod.Infrastructure.Models;
using Mongod.Infrastructure.Services;
using Mongod.Infrastructure.Services.Interfaces;
using MongoDB.Driver;

namespace Mongod
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddSingleton<IMongoClient>(new MongoClient(Configuration.GetConnectionString("mongo")));

            services.AddScoped<IService<FlatModel, Flat>,Service<FlatModel, Flat>>();
            services.AddScoped<IBaseRepository<Flat>,BaseRepository<Flat>>();
            
            services.AddAutoMapper();
            services.AddScoped<IConverter<Flat,FlatModel>,FlatConverter>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
