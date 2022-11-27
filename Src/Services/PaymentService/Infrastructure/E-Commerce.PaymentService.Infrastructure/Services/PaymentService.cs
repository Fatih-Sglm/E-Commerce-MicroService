using E_Commerce.PaymentService.Application.Models;
using E_Commerce.PaymentService.Application.Services;

namespace E_Commerce.PaymentService.Infrastructure.Services
{
    public class PaymentService : IPaymentService
    {
        public Task<bool> Payment(CreditCardInformation creditCardInformation)
        {
            return Task.FromResult(false);
        }
    }
}
