using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CommerceCraft.Api.Data
{
    public class Wishlist
    {
        [Key]
        public Guid WishlistId { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

        [JsonIgnore]
        public ICollection<WishlistItem> WishlistItems { get; set; } = new List<WishlistItem>();
    }

}
