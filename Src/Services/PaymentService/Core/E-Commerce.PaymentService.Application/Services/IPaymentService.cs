using E_Commerce.PaymentService.Application.Models;

namespace E_Commerce.PaymentService.Application.Services
{
    public interface IPaymentService
    {
        Task<bool> Payment(CreditCardInformation creditCardInformation);
    }
}
