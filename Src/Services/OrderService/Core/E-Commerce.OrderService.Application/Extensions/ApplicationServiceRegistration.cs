using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace E_Commerce.OrderService.Application.Extensions
{
    public static class ApplicationServiceRegistration
    {
        public static void AddApplicationServiceRegistration(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.AsTransient(), Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
