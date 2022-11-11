using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.OrderService.Application.Abstractions.Repostories;
using E_Commerce.OrderService.Application.Abstractions.Services;
using E_Commerce.OrderService.Application.Features.Order.Command.CreateOrder;
using E_Commerce.OrderService.Application.IntegrationEvents.Events;
using E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate;

namespace E_Commerce.OrderService.Persistence.Concrete.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IEventBus _eventBus;
        //private readonly ILogger<CreateOrderCommandHandler> _logger;


        public OrderService(IOrderRepository orderRepository, IEventBus eventBus)
        {
            //using var scope = serviceScopeFactory.CreateScope();
            //scope.ServiceProvider.GetService<IOrderRepository>();
            _orderRepository = orderRepository;
            _eventBus = eventBus;
            //_logger = logger;
        }
        public async Task CreateOrder(CreateOrderCommand request)
        {
            Address addr = new(request.Street, request.City, request.State, request.Country, request.ZipCode);
            Order dbOrder = new(request.UserName,
            addr, request.CardTypeId, request.CardNumber, request.CardSecurityNumber, request.CardHolderName, request.CardExpiration, request.OrderItems.Count(), null);
            foreach (var orderItem in request.OrderItems)
            {
                dbOrder.AddOrderItem(orderItem.ProductId, orderItem.ProductName, orderItem.UnitPrice, orderItem.PictureUrl, orderItem.Units);
            }

            await _orderRepository.AddAsync(dbOrder);
            await _orderRepository.UnitOfWork.SaveEntitiesAsync();

            //logger.LogInformation("CreateOrderCommandHandler -> dbOrder saved");

            var orderStartedIntegrationEvent = new OrderStartedIntegrationEvent(request.UserName, dbOrder.Id);

            _eventBus.Publish(orderStartedIntegrationEvent);

            //logger.LogInformation("CreateOrderCommandHandler -> OrderStartedIntegrationEvent fired");
        }
    }
}
