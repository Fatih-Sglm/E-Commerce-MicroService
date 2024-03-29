﻿using E_Commerce.EventBus.Base.Events;

namespace E_Commerce.NotificationService.IntegrationEvet.Event
{
    public class OrderPaymentFailedIntegrationEvent : IntegrationEvent
    {
        public int OrderId { get; set; }

        public string ErrorMessage { get; set; }

        public OrderPaymentFailedIntegrationEvent(int orderId, string errorMessage)
        {
            OrderId = orderId;
            ErrorMessage = errorMessage;
        }
    }
}
