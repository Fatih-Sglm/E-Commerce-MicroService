using E_Commerce.OrderService.Application.Abstractions.Repostories;
using E_Commerce.OrderService.Application.Abstractions.Services;
using E_Commerce.OrderService.Persistence.Concrete.Repository;
using E_Commerce.OrderService.Persistence.Concrete.Services;
using E_Commerce.OrderService.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.OrderService.Persistence.Extensions
{
    public static class PersistenceServiceRegistration
    {
        public static void AddPersistenceServiceRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OrderDbContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("MSS"));
                opt.EnableSensitiveDataLogging();
            });

            services.AddScoped<IBuyerRepository, BuyerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderService, Concrete.Services.OrderService>();
            services.AddScoped<IBuyerService, BuyerService>();
        }
    }
}
