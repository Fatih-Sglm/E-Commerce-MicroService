using E_Commerce.IdentityService.Application.Abstractions.Repositories;
using E_Commerce.IdentityService.Application.Abstractions.Services.AuthService;
using E_Commerce.IdentityService.Persistence.Concretes.Repositories;
using E_Commerce.IdentityService.Persistence.Concretes.Services;
using E_Commerce.IdentityService.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.IdentityService.Persistence.Extensions
{
    public static class PersistenceExtensions
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IdentityContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("MSS")));
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
