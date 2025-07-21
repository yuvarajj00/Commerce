using CommerceCraft.Api.Enum;
using CommerceCraft.Api.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CommerceCraft.Api.Data
{
    public class Order: AuditBaseEntity
    {
        [Key]
        public Guid OrderId { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

        public DateTime OrderDate { get; set; }

        

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPriceAfterDiscount { get; set; }
        

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalDiscount { get; set; }
    

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        public OrderStatus Status { get; set; }

        [JsonIgnore]
        public ICollection<OrderItem> OrderItems { get; set; }

        public ShippingAddress ShippingAddress { get; set; }

        public PaymentDetails PaymentDetails { get; set; }
    }

}
