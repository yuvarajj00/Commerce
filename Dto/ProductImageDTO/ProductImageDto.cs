using CommerceCraft.Api.Data;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CommerceCraft.Api.Dto.ProductImageDTO
{
    public class ProductImageDto
    {


            public Guid ProductImageId { get; set; }
            public string ImageUrl { get; set; }
            public string ImageName { get; set; }

            public Guid ProductId { get; set; }
            public bool IsThumbnail { get; set; } = false;
        
    }

}
