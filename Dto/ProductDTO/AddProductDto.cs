using CommerceCraft.Api.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CommerceCraft.Api.Dto.ProductDTO
{
    public class AddProductDto
    {


            [Required]
            [MaxLength(200)]
            public string Name { get; set; }

            [Required]
            public string Description { get; set; }

            [Range(0, 1_000_000)]
            public decimal OriginalPrice { get; set; }

            [Range(0, 100)]
            public decimal? DiscountPercentage { get; set; }

            [Range(0, 10_000)]
            public int StockQuantity { get; set; }

            public bool IsFeatured { get; set; }

            [Required]
            public Guid CategoryId { get; set; }

            public DateTime CreatedDate { get; set; }

            public int CreatedBy { get; set; }



    }
}
