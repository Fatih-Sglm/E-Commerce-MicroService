using E_Commerce.OrderService.Domain.SeedWork;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate
{
    public class OrderItem : BaseEntity, IValidatableObject
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string PictureUrl { get; set; }

        public decimal UnitPrice { get; set; }

        public int Units { get; set; }

        protected OrderItem()
        {

        }

        public OrderItem(int productId, string productName, decimal unitPrice, string pictureUrl, int units = 1)
        {
            ProductId = productId;

            ProductName = productName;
            UnitPrice = unitPrice;
            Units = units;
            PictureUrl = pictureUrl;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            if (Units <= 0)
                results.Add(new ValidationResult("Invalid number of units", new[] { "Units" }));

            return results;
        }
    }
}
