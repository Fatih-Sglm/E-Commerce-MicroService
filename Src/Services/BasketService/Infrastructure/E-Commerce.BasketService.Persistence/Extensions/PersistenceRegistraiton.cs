﻿using E_Commerce.BasketService.Application.Abstractions.Repository;
using E_Commerce.BasketService.Application.Abstractions.Services;
using E_Commerce.BasketService.Persistence.Concrete.Repositories;
using E_Commerce.BasketService.Persistence.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.BasketService.Persistence.Extensions
{
    public static class PersistenceRegistraiton
    {
        public static void AddPersistenceRegistraiton(this IServiceCollection services)
        {
            services.AddScoped<IBasketRepository, BasketRepository>();
            services.AddScoped<IRedisConfig, RedisConfig>();
            services.AddScoped<IBasketService, Concrete.Services.BasketService>();
        }
    }
}
