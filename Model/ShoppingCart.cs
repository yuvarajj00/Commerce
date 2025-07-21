using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommerceCraft.Api.Data
{
    public class ShoppingCart
    {
        [Key]
        public Guid ShoppingCartId { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

        public ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }

        [NotMapped]
        public decimal TotalPriceAfterDiscount =>
            ShoppingCartItems?.Sum(i => i.TotalPriceAfterDiscount) ?? 0;

        [NotMapped]
        public decimal TotalDiscount =>
            ShoppingCartItems?.Sum(i => i.TotalDiscount) ?? 0;

        [NotMapped]
        public decimal TotalPrice =>
            ShoppingCartItems?.Sum(i => i.TotalPrice) ?? 0;

        [NotMapped]
        public int TotalItems =>
            ShoppingCartItems?.Sum(i => i.Quantity) ?? 0;
    }

}
