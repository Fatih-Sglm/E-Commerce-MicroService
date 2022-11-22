﻿using E_Commerce.IdentityService.Application.Abstractions.Repositories.Common;
using E_Commerce.IdentityService.Application.Abstractions.Services.AuthService;
using E_Commerce.IdentityService.Domain.Entities.Identity;
using E_Commerce.IdentityService.Persistence.Concretes.Repositories.GenericRepo;
using E_Commerce.IdentityService.Persistence.Concretes.Services;
using E_Commerce.IdentityService.Persistence.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.IdentityService.Persistence.Extensions
{
    public static class PersistenceExtensions
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IdentityContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("MSS")));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepoitory<>));
            services.AddScoped<IAuthService, AuthService>();
            //services.AddScoped<AuthBusinnesRules>();
            AddIdenTity(services);

        }

        private static void AddIdenTity(IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.User.RequireUniqueEmail = true;

            }).AddEntityFrameworkStores<IdentityContext>()
           .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                // Default Password settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
            });
        }
    }
}
