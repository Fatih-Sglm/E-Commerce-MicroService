using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.OrderService.Application.Abstractions.Repostories;
using E_Commerce.OrderService.Application.IntegrationEvents.Events;
using E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate;
using Microsoft.Extensions.Logging;

namespace E_Commerce.OrderService.Application.IntegrationEvents.EventsHandlers
{
    public class OrderStatusChangedIntegrationEventIntegrationEventHandler : IIntegrationEventHandler<OrderStatusChangedIntegrationEvent>
    {
        private readonly ILogger<OrderStatusChangedIntegrationEventIntegrationEventHandler> _logger;
        private readonly IOrderRepository _orderRepository;

        public OrderStatusChangedIntegrationEventIntegrationEventHandler(ILogger<OrderStatusChangedIntegrationEventIntegrationEventHandler> logger, IOrderRepository orderRepository)
        {
            _logger = logger;
            _orderRepository = orderRepository;
        }

        public async Task HandleAsync(OrderStatusChangedIntegrationEvent @event)
        {
            OrderStatus orderStatus = OrderStatus.FromName(@event.OrderStatus);
            Order order = await _orderRepository.GetAsync(x => x.Id == @event.OrderId);
            order.SetOrderStatus(orderStatus);
            _orderRepository.Update(order);
            bool result = await _orderRepository.SaveChangesAsync();
            //int result = await _orderRepository.Table.Where(x => x.Id == @event.OrderId).
            //    ExecuteUpdateAsync(s => s.SetProperty(x => x.GetType().GetField("orderStatusId", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(x), orderStatus.Id));
            var message = result /*> 0*/ ? $"The Order Status column of the item with id {@event.Id} has been successfully updated to {@event.OrderStatus}." :
                $"An error occurred while updating the order status column of the order with id {@event.Id}.";
            _logger.LogInformation(message: message);
        }
    }
}
