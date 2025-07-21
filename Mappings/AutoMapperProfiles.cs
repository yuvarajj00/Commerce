using AutoMapper;
using CommerceCraft.Api.Data;
using CommerceCraft.Api.Dto.CategoryDTO;
using CommerceCraft.Api.Dto.OrderDTO;
using CommerceCraft.Api.Dto.ProductDTO;
using CommerceCraft.Api.Dto.ProductImageDTO;

namespace CommerceCraft.Api.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<AddProductDto,Product>().ReverseMap();
            CreateMap<UpdateProductDto,Product>().ReverseMap();
            CreateMap<AddProductImageDto,ProductImage>().ReverseMap();
            CreateMap<ProductImageDto, ProductImage>().ReverseMap();
            CreateMap<UpdateProductImageDto, ProductImage>().ReverseMap();
            CreateMap<OrderDto,Order>().ReverseMap();
            CreateMap<StatusDto,Order>().ReverseMap();
        }
    }
}
