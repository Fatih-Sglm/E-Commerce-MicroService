using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.OrderService.Application.Features.Orders.Command.CreateOrder;
using E_Commerce.OrderService.Application.IntegrationEvents.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace E_Commerce.OrderService.Application.IntegrationEvents.EventsHandlers
{
    public class OrderCreatedIntegrationEventHandler : IIntegrationEventHandler<OrderCreatedIntegrationEvent>
    {
        private readonly IMediator _mediator;
        private readonly ILogger<OrderCreatedIntegrationEventHandler> _logger;

        public OrderCreatedIntegrationEventHandler(IMediator mediator, ILogger<OrderCreatedIntegrationEventHandler> logger/*, IOrderService orderService*/)
        {
            _mediator = mediator;
            _logger = logger;
        }

        public async Task HandleAsync(OrderCreatedIntegrationEvent @event)
        {

            try
            {
                _logger.LogInformation("Handling integration event: {IntegrationEventId} at {AppName} - ({@IntegrationEvent})",
                @event.Id,
                typeof(OrderCreatedIntegrationEvent).Namespace,
                @event);

                CreateOrderCommand createOrderCommand = new(
                            @event.Basket.Items,
                            @event.Basket.TotalPrice,
                            @event.UserId, @event.UserName,
                            @event.City, @event.Street,
                            @event.State, @event.Country, @event.ZipCode, @event.CreditCardInformation, @event.CardTypeId);

                await _mediator.Send(createOrderCommand);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.ToString());
            }
        }
    }
}
