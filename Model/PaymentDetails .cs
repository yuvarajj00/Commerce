using CommerceCraft.Api.Model;
using System.ComponentModel.DataAnnotations;
using CommerceCraft.Api.Enum;

namespace CommerceCraft.Api.Data
{
    public class PaymentDetails : AuditBaseEntity
    {
        [Key]
        public Guid PaymentDetailsId { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

        public Guid OrderId { get; set; }

        public Order Order { get; set; }

        [Required]
        public string RazorPayOrderId { get; set; }

        public string? RazorpayPaymentId { get; set; }

        public string? RazorpaySignature { get; set; }

        public decimal Amount { get; set; }

        public PaymentStatus Status { get; set; }
    }

}
