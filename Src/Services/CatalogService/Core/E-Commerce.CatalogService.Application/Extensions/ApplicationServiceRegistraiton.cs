using E_Commerce.CatalogService.Application.Features.CatalogBrands.Rules;
using E_Commerce.CatalogService.Application.Features.CatalogCategory.Rule;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Rules;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace E_Commerce.CatalogService.Application.Extensions
{
    public static class ApplicationServiceRegistraiton
    {
        public static void AddApplicationServiceRegistraiton(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<CatalogItemBusinessRule>();
            services.AddScoped<CatalogTypeBusinessRules>();
            services.AddScoped<CatalogBrandBusinessRules>();
        }
    }
}
