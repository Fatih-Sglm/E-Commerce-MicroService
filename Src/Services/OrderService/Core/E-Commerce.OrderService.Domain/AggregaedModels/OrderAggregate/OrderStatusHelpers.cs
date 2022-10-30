namespace E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate
{
    internal static class OrderStatusHelpers
    {
        public static OrderStatus Submitted = new(1, nameof(Submitted).ToLowerInvariant());
    }
}