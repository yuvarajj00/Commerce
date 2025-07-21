using AutoMapper;
using CommerceCraft.Api.Data;
using CommerceCraft.Api.Dto;
using CommerceCraft.Api.Dto.ProductImageDTO;
using CommerceCraft.Api.Interface.Repository;
using CommerceCraft.Api.Interface.Service;

namespace CommerceCraft.Api.Service
{
    public class ProductImageService : IProductImageService
    {
        private readonly IProductImageRepository _productImageRepository;
        private readonly IMapper _mapper;

        public ProductImageService(IProductImageRepository productImageRepository,IMapper mapper)
        {
            _productImageRepository = productImageRepository;
            _mapper = mapper;
        }
        public async Task<ApiResponseDto<ProductImageDto>> AddProductImage(AddProductImageDto addProductImageDto)
        {
            var productImageModel = _mapper.Map<ProductImage>(addProductImageDto);

           var responseProductImage = await _productImageRepository.AddProductImageAsync(productImageModel);

            var productImageDto = _mapper.Map<ProductImageDto>(responseProductImage);

            var NewResponse = new ApiResponseDto<ProductImageDto>()
            {
                Success = true,
                Message = "ProductImage added succesfully",
                Data = productImageDto
            };

            return NewResponse;
        }

        public async Task<ApiResponseDto<ProductImageDto>> DeleteProductImage(Guid productId)
        {
            var DeletedProductModel =await _productImageRepository.DeleteProductImageAsync(productId);

            var DeletedProductDto = _mapper.Map<ProductImageDto>(DeletedProductModel);

            var NewResponse = new ApiResponseDto<ProductImageDto>()
            {
                Success = true,
                Message = "ProductImage deleted Successfully",
                Data = DeletedProductDto
            };

            return NewResponse;
        }

        public async Task<ApiResponseDto<List<ProductImageDto>>> GetAllProdutsbyProductId(Guid productId)
        {
            var ProductImagesModel = await _productImageRepository.GetAllProductImagesByProductIdAsync(productId);
            var productImagesDto = _mapper.Map<List<ProductImageDto>>(ProductImagesModel);

            var NewResponse = new ApiResponseDto<List<ProductImageDto>>()
            {
                Success = true,
                Message ="all product images",
                Data = productImagesDto
            };

            return NewResponse;
        }

        public async Task<ApiResponseDto<ProductImageDto>> GetImageById(Guid productImageId)
        {
            var productImageModel = await _productImageRepository.GetProductImagebyIdAsync(productImageId);

            var productImageDto = _mapper.Map<ProductImageDto>(productImageModel);

            var NewResponse = new ApiResponseDto<ProductImageDto>()
            {
                Success = true,
                Message = "fetched success",
                Data= productImageDto
            };
            return NewResponse;
        }

        public async Task<ApiResponseDto<ProductImageDto>> UpdateProductImage(Guid productId, UpdateProductImageDto updateProductImageDto)
        {
            var updateProductImageModel = _mapper.Map<ProductImage>(updateProductImageDto);

            updateProductImageModel = await _productImageRepository.UpdateProductImageAsync(productId, updateProductImageModel);

            var updatedImageDto = _mapper.Map<ProductImageDto>(updateProductImageModel);

            var NewResponse = new ApiResponseDto<ProductImageDto>()
            {
                Success = true,
                Message = "Updated Successfully",
                Data = updatedImageDto
            };
            return NewResponse;

        }
    }
}
