using System.ComponentModel.DataAnnotations;

namespace CommerceCraft.Api.Dto.ProductDTO
{
    public class UpdateProductDto
    {


        [MaxLength(200)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(0, 1_000_000)]
        public decimal OriginalPrice { get; set; }

        [Range(0, 100)]
        public decimal? DiscountPercentage { get; set; }

        [Range(0, 10_000)]
        public int StockQuantity { get; set; }

        public bool IsFeatured { get; set; }

        public Guid CategoryId { get; set; }

    }

}
