using System.ComponentModel.DataAnnotations;

namespace CommerceCraft.Api.Dto.CategoryDTO
{
    public class CategoryDto
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }

        public string ImageUrl { get; set; }

    }
}
