using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CommerceCraft.Api.Data
{
    public class ShoppingCartItem
    {
        [Key]
        public Guid ShoppingCartItemId { get; set; }

        public Guid ShoppingCartId { get; set; }

        [JsonIgnore]
        public ShoppingCart ShoppingCart { get; set; }

        public Guid ProductId { get; set; }

        public Product Product { get; set; }

        [Range(1, 100)]
        public int Quantity { get; set; }

        [NotMapped]
        public decimal TotalPriceAfterDiscount =>
            (Product?.NewPrice ?? 0) * Quantity;

        [NotMapped]
        public decimal TotalDiscount =>
            ((Product?.OriginalPrice ?? 0) - (Product?.NewPrice ?? 0)) * Quantity;

        [NotMapped]
        public decimal TotalPrice =>
            (Product?.OriginalPrice ?? 0) * Quantity;
    }

}
