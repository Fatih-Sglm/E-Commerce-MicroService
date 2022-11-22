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
        }
    }
}
