using AutoMapper;
using CommerceCraft.Api.Data;
using CommerceCraft.Api.Dto;
using CommerceCraft.Api.Dto.ProductDTO;
using CommerceCraft.Api.Interface.Repository;
using CommerceCraft.Api.Interface.Service;

namespace CommerceCraft.Api.Service
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        public ProductService(IMapper mapper,IProductRepository productRepository) 
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public IProductRepository ProductRepository { get; }

        public async Task<ApiResponseDto<ProductDto>> AddProduct(AddProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            product = await _productRepository.AddProductAsync(product);

            var responseDto = _mapper.Map<ProductDto>(product);

            var NewApiResponse = new ApiResponseDto<ProductDto>()
            {
                Success = true,
                Message = "Product added Successfully",
                Data = responseDto
            };
            return NewApiResponse;
        }

        public async Task DeleteProduct(Guid productId)
        {
           await _productRepository.DeleteProductAsync(productId);
        }

        public async Task<ApiResponseDto<List<ProductDto>>> GetAllProducts()
        {
            var AllProductsModel =await _productRepository.GetAllProductsAsync();

            var AllProductsDto = _mapper.Map<List<ProductDto>>(AllProductsModel);

            var NewReponse = new ApiResponseDto<List<ProductDto>>()
            {
                Success = true,
                Message = "Products fetched Successfully",
                Data = AllProductsDto

            };
            return NewReponse;
        }

        public async Task<ApiResponseDto<ProductDto>> GetProductDetilas(Guid productId)
        {
            var productModel = await _productRepository.GetProductByIdAsync(productId);

            var productDto = _mapper.Map<ProductDto>(productModel);

            return new ApiResponseDto<ProductDto>()
            {
                Success = true,
                Message = $"{productId}",
                Data = productDto
            };
        }

        public async Task<ApiResponseDto<ProductDto>> UpdateProduct(Guid productId, UpdateProductDto updateProductDto)
        {
            var updateProductModel = _mapper.Map<Product>(updateProductDto);

            updateProductModel =await _productRepository.UpdateProductAsync(productId, updateProductModel);

            var updatedProductDto = _mapper.Map<ProductDto>(updateProductModel);

            var NewApiResponse = new ApiResponseDto<ProductDto>()
            {
                Success = true,
                Message = "Product Updated Successfully",
                Data = updatedProductDto,
            };
            return NewApiResponse;

        }


    }
}
