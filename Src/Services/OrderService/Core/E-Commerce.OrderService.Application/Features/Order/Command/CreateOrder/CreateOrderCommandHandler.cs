using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.OrderService.Application.Abstractions.Repostories;
using E_Commerce.OrderService.Application.IntegrationEvents.Events;
using E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate;
using MediatR;
using Ord = E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate.Order;

namespace E_Commerce.OrderService.Application.Features.Order.Command.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, bool>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IEventBus _eventBus;
        //private readonly ILogger<CreateOrderCommandHandler> _logger;


        public CreateOrderCommandHandler(IOrderRepository orderRepository, IEventBus eventBus)
        {
            //using var scope = serviceScopeFactory.CreateScope();
            //_orderRepository = scope.ServiceProvider.GetRequiredService<IOrderRepository>();
            _orderRepository = orderRepository;
            _eventBus = eventBus;
            //_logger = logger;
        }

        public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            //logger.LogInformation("CreateOrderCommandHandler -> Handle method invoked");

            Address addr = new(request.Street, request.City, request.State, request.Country, request.ZipCode);

            Ord dbOrder = new(request.UserName,
                addr, request.CardTypeId, request.CardNumber, request.CardSecurityNumber, request.CardHolderName, request.CardExpiration, request.OrderItems.Count(), null);

            foreach (var orderItem in request.OrderItems)
            {
                dbOrder.AddOrderItem(orderItem.ProductId, orderItem.ProductName, orderItem.UnitPrice, orderItem.PictureUrl, orderItem.Units);
            }

            await _orderRepository.AddAsync(dbOrder);
            await _orderRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            //logger.LogInformation("CreateOrderCommandHandler -> dbOrder saved");

            var orderStartedIntegrationEvent = new OrderStartedIntegrationEvent(request.UserName, dbOrder.Id);

            _eventBus.Publish(orderStartedIntegrationEvent);

            //logger.LogInformation("CreateOrderCommandHandler -> OrderStartedIntegrationEvent fired");

            return true;
        }
    }
}
