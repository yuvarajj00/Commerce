using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CommerceCraft.Api.Data
{
    public class WishlistItem
    {
        [Key]
        public Guid WishlistItemId { get; set; }

        public Guid WishlistId { get; set; }

        [JsonIgnore]
        public Wishlist Wishlist { get; set; }

        public Guid ProductId { get; set; }

        public Product Product { get; set; }
    }

}
