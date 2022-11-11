using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.OrderService.Api.IntegrationEvents.Events;
using E_Commerce.OrderService.Application.Features.Order.Command.CreateOrder;
using MediatR;

namespace E_Commerce.OrderService.Api.IntegrationEvents.EventsHandlers
{
    public class OrderCreatedIntegrationEventHandler : IIntegrationEventHandler<OrderCreatedIntegrationEvent>
    {
        private readonly IMediator _mediator;
        private readonly ILogger<OrderCreatedIntegrationEventHandler> _logger;
        //private readonly IOrderService _orderService;

        public OrderCreatedIntegrationEventHandler(IMediator mediator, ILogger<OrderCreatedIntegrationEventHandler> logger/*, IOrderService orderService*/)
        {
            _mediator = mediator;
            _logger = logger;
            // _orderService = orderService;
        }

        public async Task HandleAsync(OrderCreatedIntegrationEvent @event)
        {

            try
            {
                //_logger.LogInformation("Handling integration event: {IntegrationEventId} at {AppName} - ({@IntegrationEvent})",
                //@event.Id,
                //typeof(OrderCreatedIntegrationEvent).Namespace,
                //@event);

                CreateOrderCommand createOrderCommand = new(@event.Basket.Items,
                            @event.UserId, @event.UserName,
                            @event.City, @event.Street,
                            @event.State, @event.Country, @event.ZipCode,
                            @event.CardNumber, @event.CardHolderName, @event.CardExpiration,
                            @event.CardSecurityNumber, @event.CardTypeId);

                //await _orderService.CreateOrder(createOrderCommand);
                await _mediator.Send(createOrderCommand);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.ToString());
            }
        }
    }
}
