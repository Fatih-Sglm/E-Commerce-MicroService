using E_Commerce.BasketService.Domain.Models;
using FluentValidation;

namespace E_Commerce.BasketService.Application.Validations
{
    public class BasketCheckoutValidations : AbstractValidator<BasketCheckout>
    {
        public BasketCheckoutValidations()
        {
            RuleFor(i => i.CardNumber).NotEmpty().WithMessage("kart numarası Boş").CreditCard().WithMessage("Geçersiz Kart Numarası");
            RuleFor(i => i.CardHolderName).NotNull().NotEmpty().WithMessage("Kart Üzerinde isim boş geçilemez");
            RuleFor(i => i.CardSecurityNumber).NotNull().NotEmpty().WithMessage("Cvc boş geçilemez");
        }
    }
}
