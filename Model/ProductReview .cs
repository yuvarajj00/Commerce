using CommerceCraft.Api.Model;
using System.ComponentModel.DataAnnotations;

namespace CommerceCraft.Api.Data
{
    public class ProductReview : AuditBaseEntity
    {
        [Key]
        public Guid ProductReviewId { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Review { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public Guid ProductId { get; set; }

        public Product Product { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }
    }

}
