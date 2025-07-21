using CommerceCraft.Api.Dto;
using CommerceCraft.Api.Dto.ProductDTO;

namespace CommerceCraft.Api.Interface.Service
{
    public interface IProductService
    {
        Task<ApiResponseDto<ProductDto>> AddProduct(AddProductDto product);

        Task<ApiResponseDto<List<ProductDto>>> GetAllProducts();

        Task<ApiResponseDto<ProductDto>> UpdateProduct(Guid productId, UpdateProductDto updateProductDto);

        Task DeleteProduct(Guid productId);

        Task<ApiResponseDto<ProductDto>> GetProductDetilas(Guid productId);
    }
}
