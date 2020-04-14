using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using DAL.DbContexts;
using DAL.Interfaces.EFInterfaces.IEFRepositories;
using DAL.Repositories.EFRepositories;
using DAL.Interfaces;
using DAL.UnitOfWork;
using BLL.Interfaces.IEFServices;
using BLL.Services.EF_Services;
using AutoMapper;
using DAL.Entities;
using BLL.DTO;
using DAL.Repositories;

namespace VideoGameShop2
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
            services.AddDbContext<MyDbContext>(cfg =>
            {
                cfg.UseSqlServer(Configuration.GetConnectionString("Default"), b => b.MigrationsAssembly("VideoGameShop2"));
            });

            services.AddAutoMapper(cfg =>
            {
                cfg.CreateMap<Developer, DeveloperDTO>();
                cfg.CreateMap<Game, GameDTO>();
                cfg.CreateMap<Genre, GenreDTO>();
                cfg.CreateMap<Publisher, PublisherDTO>();
                cfg.CreateMap<UserBought, UserBoughtDTO>();
                cfg.CreateMap<User, UserDTO>();

                cfg.CreateMap<DeveloperDTO, Developer>();
                cfg.CreateMap<GameDTO, Game>();
                cfg.CreateMap<GenreDTO, Genre>();
                cfg.CreateMap<PublisherDTO, Publisher>();
                cfg.CreateMap<UserBoughtDTO, UserBought>();
                cfg.CreateMap<UserDTO, User>();
            }, typeof(Startup));

            services.AddTransient<IEFDeveloperRepository, EFDeveloperRepository>();
            services.AddTransient<IEFGameRepository, EFGameRepository>();
            services.AddTransient<IEFGenreRepository, EFGenreRepository>();
            services.AddTransient<IEFPublisherRepository, EFPublisherRepository>();
            services.AddTransient<IEFUserBoughtRepository, EFUserBoughtRepository>();
            services.AddTransient<IEFUserRepository, EFUserRepository>();

            services.AddTransient<IEFUnitOfWork, EFUnitOfWork>();

            services.AddTransient<IEFDeveloperService,EFDeveloperService>();
            services.AddTransient<IEFGameService, EFGameService>();
            services.AddTransient<IEFGenreService,EFGenreService>();
            services.AddTransient<IEFPublisherService, EFPublisherService>();
            services.AddTransient<IEFUserBoughtService,EFUserBoughtService>();
            services.AddTransient<IEFUserService,EFUserService>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
