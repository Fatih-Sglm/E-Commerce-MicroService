using E_Commerce.CatalogService.Application.Abstractions.Repositories;
using E_Commerce.CatalogService.Application.Abstractions.Services;
using E_Commerce.CatalogService.Persistence.Concretes.Repositories;
using E_Commerce.CatalogService.Persistence.Concretes.Services;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.CatalogService.Persistence.Extension
{
    public static class PersistenceServiceRegistraiton
    {
        public static void AddPersistenceServiceRegistraiton(this IServiceCollection services)
        {
            services.AddScoped<ICatalogBrandRepository, CatalogBrandRepository>();
            services.AddScoped<ICatalogBrandRepository, CatalogBrandRepository>();
            services.AddScoped<ICatalogTypeRepository, CatalogTypeRepository>();
            services.AddScoped<ICatalogItemVariantRepository, CatalogItemVariantRepository>();
            services.AddScoped<ICatalogItemImageService, CatalogItemImageService>();
            services.AddScoped<ICatalogItemsService, CatalogItemsService>();
            services.AddScoped<ICatalogItemRepository, CatalogItemRepository>();
            services.AddScoped<ICatalogTypeService, CatalogTypeService>();
            services.AddScoped<ICatalogBrandService, CatalogBrandService>();
            services.AddScoped<ICatalogItemVariantService, CatalogItemVariantService>();
        }
    }
}
