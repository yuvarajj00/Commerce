using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CommerceCraft.Api.Data
{
    public class ShippingAddress
    {
        [Key]
        public Guid ShippingAddressId { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(255)]
        public string AddressLine1 { get; set; }

        [MaxLength(255)]
        public string? AddressLine2 { get; set; }

        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MaxLength(100)]
        public string State { get; set; }

        [Required]
        [MaxLength(20)]
        public string PostalCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string Country { get; set; }

        public Guid OrderId { get; set; }

        [JsonIgnore]
        public Order Order { get; set; }
    }

}
