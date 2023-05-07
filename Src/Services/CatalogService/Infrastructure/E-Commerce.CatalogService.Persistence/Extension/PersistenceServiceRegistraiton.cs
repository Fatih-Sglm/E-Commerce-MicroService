using E_Commerce.CatalogService.Application.Abstractions.Repositories;
using E_Commerce.CatalogService.Application.Abstractions.Services;
using E_Commerce.CatalogService.Application.Abstractions.Services.CatalogItems;
using E_Commerce.CatalogService.Persistence.Concretes.Repositories;
using E_Commerce.CatalogService.Persistence.Concretes.Services;
using E_Commerce.CatalogService.Persistence.Concretes.Services.CatalogItems;
using E_Commerce.CatalogService.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.CatalogService.Persistence.Extension
{
    public static class PersistenceServiceRegistraiton
    {
        public static void AddPersistenceServiceRegistraiton(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddScoped<ICatalogBrandRepository, CatalogBrandRepository>();
            services.AddScoped<ICatalogBrandRepository, CatalogBrandRepository>();
            services.AddScoped<ICatalogTypeRepository, CatalogTypeRepository>();
            services.AddScoped<ICatalogItemVariantRepository, CatalogItemVariantRepository>();
            services.AddScoped<ICatalogItemImageService, CatalogItemImageService>();
            services.AddScoped<ICatalogItemWriteService, CatalogItemWriteService>();
            services.AddScoped<ICatalogItemReadService, CatalogItemReadService>();
            services.AddScoped<ICatalogItemRepository, CatalogItemRepository>();
            services.AddScoped<ICatalogTypeService, CatalogTypeService>();
            services.AddScoped<ICatalogBrandService, CatalogBrandService>();
            services.AddScoped<ICatalogItemVariantService, CatalogItemVariantService>();

            services.AddDbContext<CatalogContext>(opt => opt.
                                 UseSqlServer(string.Format(configuration.GetConnectionString("MSS"), configuration["SqlPass"])));
            services.AddSingleton(sp => sp.DbInitialize());
        }

        public static IServiceProvider DbInitialize(this IServiceProvider provider)
        {
            using var scope = provider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<CatalogContext>();
            context.Database.Migrate();
            return provider;
        }
    }
}
