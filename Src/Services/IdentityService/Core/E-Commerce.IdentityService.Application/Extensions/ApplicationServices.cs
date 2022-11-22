using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace E_Commerce.IdentityService.Application.Extensions
{
    public static class ApplicationServices
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddMediatR(assembly);
            services.AddAutoMapper(assembly);
        }
    }
}
