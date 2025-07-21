using CommerceCraft.Api.Dto;
using CommerceCraft.Api.Dto.ProductImageDTO;

namespace CommerceCraft.Api.Interface.Service
{
    public interface IProductImageService
    {
        Task<ApiResponseDto<ProductImageDto>> AddProductImage(AddProductImageDto AddPSroductImageDto);
        Task<ApiResponseDto<ProductImageDto>> UpdateProductImage(Guid productId ,UpdateProductImageDto updateProductImageDto);

        Task<ApiResponseDto<List<ProductImageDto>>> GetAllProdutsbyProductId(Guid productId);

        Task<ApiResponseDto<ProductImageDto>> DeleteProductImage(Guid productId); 

        Task<ApiResponseDto<ProductImageDto>> GetImageById(Guid productImageId);
    }
}
