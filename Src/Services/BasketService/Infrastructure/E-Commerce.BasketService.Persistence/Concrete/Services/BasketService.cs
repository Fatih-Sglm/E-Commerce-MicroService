using E_Commerce.BasketService.Application.Abstractions.Repository;
using E_Commerce.BasketService.Application.Abstractions.Services;
using E_Commerce.BasketService.Application.IntegrationEvents.Events;
using E_Commerce.BasketService.Domain.Models;
using E_Commerce.EventBus.Base.Abstraction;
using Microsoft.Extensions.Logging;

namespace E_Commerce.BasketService.Persistence.Concrete.Services
{
    public class BasketService : IBasketService
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IIdentityService _identityService;
        private readonly IEventBus _eventBus;
        private readonly ILogger<BasketService> _logger;

        public BasketService(IBasketRepository basketRepository, IIdentityService identityService, IEventBus eventBus, ILogger<BasketService> logger)
        {
            _basketRepository = basketRepository;
            _identityService = identityService;
            _eventBus = eventBus;
            _logger = logger;
        }

        public async Task AddItemToBasket(BasketItem basketItem)
        {
            var userId = _identityService.GetUserName();
            var basket = await _basketRepository.GetBasketAsync(userId);
            if (basket is null)
            {
                basket = new CustomerBasket(userId);
            }
            basket.Items.Add(basketItem);
            await _basketRepository.UpdateBasketAsync(basket);
        }

        public async Task CheckOutAsync(BasketCheckout basketCheckout)
        {
            var userId = basketCheckout.Buyer;
            var basket = await _basketRepository.GetBasketAsync(userId);

            if (basket is null)
            {
                return;
            }
            var eventmessage = new OrderCreatedIntegrationEvent
                (userId, username, basketCheckout.City, basketCheckout.Street,
            basketCheckout.Street, basketCheckout.Country, basketCheckout.ZipCode, basketCheckout.CardNumber, basketCheckout.CardHolderName,
            basketCheckout.CardExpiration, basketCheckout.CardSecurityNumber, basketCheckout.CardTypeId, basketCheckout.Buyer,
            basket);

            try
            {
                _eventBus.Publish(eventmessage);
            }
            catch (Exception)
            {
                _logger.LogError($"Mesaj Publish edilirken bir hata oluştu Mesaj id : {eventmessage.Id}");

                return;
            }



        }

        public Task DeleteBasketByIdAsync(string id)
        {
            var username = await _identityService.GetUserName();
            await _basketRepository.DeleteBasketItemAsync(username, id);
        }

        public async Task<CustomerBasket> GetBasket()
        {
            var basket = await _basketRepository.GetBasketAsync(id);

            return basket ?? new CustomerBasket(id);
        }

        public async Task<CustomerBasket?> UpdateBasketAsync(CustomerBasket customerBasket)
        {
            return await _basketRepository.UpdateBasketAsync(customerBasket);
        }
    }
}
