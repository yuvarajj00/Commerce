using CommerceCraft.Api.Model;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CommerceCraft.Api.Data
{
    public class Category : AuditBaseEntity
    {
        [Key]
        public Guid CategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Url]
        public string ImageUrl { get; set; }

        [JsonIgnore]
        public ICollection<Product> Products { get; set; }
    }

}
