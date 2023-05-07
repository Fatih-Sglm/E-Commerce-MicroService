using E_Commerce.EventBus.Base.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.IdentityService.Application.IntegrationEvents
{
    public class UserNotificationIntegrationEvent : IntegrationEvent
    {
        public string UrlRoute { get; init; }
        public string FullName { get; init; }
        public string UserId { get; init; }
        public string Email { get;  init; }
        public string Token { get; init; }
        public MessageType MessageType { get; init; }

        
    }
    
    public enum MessageType
    {
        ReserPassword,
        VerifyEmail
    }
}
