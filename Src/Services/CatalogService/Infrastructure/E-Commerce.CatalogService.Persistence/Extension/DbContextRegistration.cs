using E_Commerce.CatalogService.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.CatalogService.Persistence.Extension
{
    public static class DbContextRegistration
    {
        public static void AddDbContextServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CatalogContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("MSS")));
        }
    }
}
