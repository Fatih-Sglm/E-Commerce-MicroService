using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.NotificationService.IntegrationEvet.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.NotificationService.IntegrationEvet.EventHandler
{
    public class UserNotificationIntegrationEventHandler : IIntegrationEventHandler<UserNotificationIntegrationEvent>
    {
        public async Task HandleAsync(UserNotificationIntegrationEvent @event)
        {
            Console.WriteLine("Hello World");
        }
    }
}
