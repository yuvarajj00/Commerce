using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CommerceCraft.Api.Data
{
    public class OrderItem
    {
        [Key]
        public Guid OrderItemId { get; set; }

        public Guid OrderId { get; set; }

        [JsonIgnore]
        public Order Order { get; set; }

        public Guid ProductId { get; set; }

        public Product Product { get; set; }

        [Range(1, 100)]
        public int Quantity { get; set; }

        public decimal TotalPriceAfterDiscount { get; set; }

        public decimal TotalDiscount { get; set; }

        public decimal TotalPrice { get; set; }
    }

}
