using E_Commerce.BasketService.Application.Abstractions.Repository;
using E_Commerce.BasketService.Application.IntegrationEvents.Events;
using E_Commerce.EventBus.Base.Abstraction;
using Microsoft.Extensions.Logging;

namespace E_Commerce.BasketService.Application.IntegrationEvents.EventsHandler
{
    public class OrderCreatedIntegrationEventEventEventHandler : IIntegrationEventHandler<OrderCreatedIntegrationEvent>
    {
        private readonly IBasketRepository _basketRepository;
        private readonly ILogger<OrderCreatedIntegrationEvent> _logger;

        public OrderCreatedIntegrationEventEventEventHandler(IBasketRepository repository, ILogger<OrderCreatedIntegrationEvent> logger)
        {
            _basketRepository = repository;
            _logger = logger;
        }
        public async Task HandleAsync(OrderCreatedIntegrationEvent @event)
        {
            _logger.LogInformation("----- Handling integration event: {IntegrationEventId} at BasketService.Api - ({@IntegrationEvent})", @event.Id, @event);
            //await _basketRepository.DeleteBasketAsync(@event.UserName);
        }
    }
}
