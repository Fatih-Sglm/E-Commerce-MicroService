using E_Commerce.PaymentService.Api.Models;

namespace E_Commerce.PaymentService.Application.Services
{
    public interface IPaymentService
    {
        Task Payment(CreditCardInformation creditCardInformation);
    }
}
