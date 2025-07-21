namespace CommerceCraft.Api.Dto.ProductImageDTO
{
    public class UpdateProductImageDto
    {
        public string ImageUrl { get; set; }
        public string ImageName { get; set; }

        public Guid ProductId { get; set; }
        public bool IsThumbnail { get; set; } = false;
    }
}
