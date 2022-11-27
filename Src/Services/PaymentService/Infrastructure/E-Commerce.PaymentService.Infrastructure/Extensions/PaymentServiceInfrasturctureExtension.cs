using E_Commerce.PaymentService.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.PaymentService.Infrastructure.Extensions
{
    public static class PaymentServiceInfrasturctureExtension
    {
        public static void AddPaymentServiceInfrasturctureExtension(this IServiceCollection services)
        {
            services.AddTransient<IPaymentService, Services.PaymentService>();
        }
    }
}
