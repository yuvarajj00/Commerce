using CommerceCraft.Api.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CommerceCraft.Api.Data
{
    public class Product : AuditBaseEntity
    {
        [Key]
        public Guid ProductId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(0, 1_000_000)]
        public decimal OriginalPrice { get; set; }

        [Range(0, 100)]
        public decimal? DiscountPercentage { get; set; }

        [NotMapped]
        public decimal NewPrice =>
            (DiscountPercentage.HasValue && DiscountPercentage.Value > 0)
                ? OriginalPrice - (OriginalPrice * DiscountPercentage.Value / 100)
                : OriginalPrice;

        [NotMapped]
        public bool IsOnDiscount =>
            (DiscountPercentage.HasValue && DiscountPercentage.Value > 0);

        [Range(0, 10_000)]
        public int StockQuantity { get; set; }

        [NotMapped]
        public bool InStock => StockQuantity > 0;

        public double AverageRating { get; set; } = 0;

        public int TotalReviews { get; set; } = 0;

        public bool IsFeatured { get; set; } = false;

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }

        [JsonIgnore]
        public ICollection<ProductReview> ProductReviews { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }

        [JsonIgnore]
        public ICollection<OrderItem> OrderItems { get; set; }

        [JsonIgnore]
        public ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }

        [JsonIgnore]
        public ICollection<WishlistItem> WishlistItems { get; set; }
    }

}
