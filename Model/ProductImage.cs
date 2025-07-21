using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CommerceCraft.Api.Data
{
    public class ProductImage
    {
        [Key]
        public Guid ProductImageId { get; set; }

        [Required]
        [Url]
        public string ImageUrl { get; set; }

        [Required]
        [MaxLength(100)]
        public string ImageName { get; set; }

        public Guid ProductId { get; set; }

        [JsonIgnore]
        public Product Product { get; set; }

        public bool IsThumbnail { get; set; } = false;
    }
}
