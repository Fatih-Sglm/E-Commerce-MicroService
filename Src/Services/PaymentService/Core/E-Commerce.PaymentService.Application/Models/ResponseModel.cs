using Stripe;

namespace E_Commerce.PaymentService.Application.Models
{
    public class ResponseModel
    {
        public bool IsPaid { get; set; }
        public string? ErrorMessage { get; set; }
        public long TotalAmount { get; set; }
        public string Currency { get; set; }
        public string ReceiptNumber { get; set; }
        public string ReceiptUrl { get; set; }
        public Invoice Invoice { get; set; }
    }
}
