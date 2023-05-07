using CloudinaryDotNet;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.CatalogService.Infrastructure.Extensions
{
    public static class CloudinaryConnectExtension
    {
        public static IServiceCollection AddCloudinary(this IServiceCollection services , IConfiguration configuration)
        {
            Account account = configuration.GetSection("Cloudinary:Account").Get<Account>();
            services.AddSingleton(opt => new Cloudinary(account));
            return services;
        }
    }

    
}
