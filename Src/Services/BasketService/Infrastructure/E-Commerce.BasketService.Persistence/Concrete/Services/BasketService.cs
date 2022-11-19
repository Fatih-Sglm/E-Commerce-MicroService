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
            var userName = await _identityService.GetUserName();
            var basket = await _basketRepository.GetBasketAsync(userName);
            basket ??= new CustomerBasket(userName);
            basket.Items.Add(basketItem);
            await _basketRepository.UpdateBasketAsync(basket);
        }

        public async Task CheckOutAsync(BasketCheckout basketCheckout)
        {
            var username = await _identityService.GetUserName();
            var basket = await _basketRepository.GetBasketAsync(username);

            if (basket is null)
            {
                return;
            }
            var eventmessage = new OrderCreatedIntegrationEvent
                (username, basketCheckout.City, basketCheckout.Street,
            basketCheckout.Street, basketCheckout.Country, basketCheckout.ZipCode, basketCheckout.Alias!, basketCheckout.CardNumber, basketCheckout.CardHolderName,
            basketCheckout.CardExpiration, basketCheckout.CardSecurityNumber, basketCheckout.CardTypeId,
            basket, basketCheckout.WillPaymentRecorded);

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
        public async Task DeleteBasketByIdAsync(string id)
        {
            await _basketRepository.DeleteBasketAsync(id);
        }

        public async Task DeleteBasketItemAsync(string id)
        {
            var username = await _identityService.GetUserName();
            await _basketRepository.DeleteBasketItemAsync(username, id);
        }

        public async Task<CustomerBasket> GetBasket()
        {
            var username = await _identityService.GetUserName();
            var basket = await _basketRepository.GetBasketAsync(username);
            var userName = await _identityService.GetUserName();
            return basket ?? new CustomerBasket(userName);
        }

        public async Task<CustomerBasket?> UpdateBasketAsync(CustomerBasket customerBasket)
        {
            return await _basketRepository.UpdateBasketAsync(customerBasket);
        }
    }
}
