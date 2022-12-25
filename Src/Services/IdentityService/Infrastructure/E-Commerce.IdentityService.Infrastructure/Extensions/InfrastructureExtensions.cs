using E_Commerce.IdentityService.Application.Abstractions.Services;
using E_Commerce.IdentityService.Application.Abstractions.Services.Jwt;
using E_Commerce.IdentityService.Infrastructure.Concretes.HostedService;
using E_Commerce.IdentityService.Infrastructure.Concretes.Services;
using E_Commerce.IdentityService.Infrastructure.Concretes.Services.JwtHelper;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.IdentityService.Infrastructure.Extensions
{
    public static class InfrastructureExtensions
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenHelper, TokenHelper>();
            services.AddScoped<IMailService, MailService>();
            services.AddSingleton<IMailService, MailService>();
            services.AddHostedService<MailQueueService>();
        }
    }
}
