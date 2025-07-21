using CommerceCraft.Api.Data;
using CommerceCraft.Api.Dto.CategoryDTO;
using CommerceCraft.Api.Dto.ProductImageDTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CommerceCraft.Api.Dto.ProductDTO
{
    public class ProductDto
    {
            public Guid ProductId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal OriginalPrice { get; set; }
            public decimal DiscountPercentage { get; set; }

            public decimal NewPrice { get; set; }
            public bool IsOnDiscount { get; set; }
            public int StockQuantity { get; set; }
            public bool InStock { get; set; }
            public double AverageRating { get; set; }
            public int TotalReviews { get; set; }
            public bool IsFeatured { get; set; }
            public DateTime? ModifiedDate { get; set; }

            public int? ModifiedBy { get; set; }

             public Guid CategoryId { get; set; }
            public CategoryDto Category { get; set; }  // assuming you want category name here
            
            public ICollection<ProductImageDto> ProductImages { get; set; }



    }
}
