using E_Commerce.OrderService.Application.Abstractions.Repostories;
using E_Commerce.OrderService.Domain.AggregaedModels.BuyerAggregate;
using E_Commerce.OrderService.Domain.Events;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.OrderService.Application.DomainEventHandlers
{
    class OrderStartedDomainEventHandler : INotificationHandler<OrderStartedDomainEvent>
    {
        private readonly IBuyerRepository _buyerRepository;

        public OrderStartedDomainEventHandler(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }

        public async Task Handle(OrderStartedDomainEvent orderStartedEvent, CancellationToken cancellationToken)
        {
            var cardTypeId = (orderStartedEvent.CardTypeId != 0) ? orderStartedEvent.CardTypeId : 1;

            Buyer? buyer = await _buyerRepository.GetAsync(i => i.Name == orderStartedEvent.UserName, i => i.Include(i => i.PaymentMethods));

            bool buyerOriginallyExisted = buyer != null;

            if (!buyerOriginallyExisted)
            {
                buyer = new Buyer(orderStartedEvent.UserName);
            }

            buyer.VerifyOrAddPaymentMethod(cardTypeId,
                                          $"",
                                          orderStartedEvent.CardNumber,
                                          orderStartedEvent.CardSecurityNumber,
                                          orderStartedEvent.CardHolderName,
                                          orderStartedEvent.CardExpiration,
                                          orderStartedEvent.Order.Id);

            var buyerUpdated = buyerOriginallyExisted ?
                _buyerRepository.Update(buyer) :
                await _buyerRepository.AddAsync(buyer);

            await _buyerRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            // order status changed event may be fired here
        }
    }
}
