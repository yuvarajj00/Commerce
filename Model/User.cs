using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json.Serialization;
using CommerceCraft.Api.Enum;
using CommerceCraft.Api.Model;

namespace CommerceCraft.Api.Data
{
    public class User: AuditBaseEntity
    {
        [Key]
        public Guid UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(255)]
        public string Email { get; set; }

        [Required]
        [Phone]
        public long PhoneNumber { get; set; }

        [Required]
        [MaxLength(255)]
        public string Password { get; set; }

        public UserRole Role { get; set; }

        [JsonIgnore]
        public ICollection<Address> Addresses { get; set; }

        public string RefreshToken { get; set; }

        public DateTime RefreshTokenExpire { get; set; }

        [JsonIgnore]
        public ICollection<Order> Orders { get; set; }

        public ShoppingCart ShoppingCart { get; set; }

        public Wishlist Wishlist { get; set; }

    }
}
