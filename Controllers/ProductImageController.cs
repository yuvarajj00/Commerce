using CommerceCraft.Api.Dto.ProductDTO;
using CommerceCraft.Api.Dto.ProductImageDTO;
using CommerceCraft.Api.Interface.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CommerceCraft.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImageController : ControllerBase
    {
        private readonly IProductImageService _productImageService;

        public ProductImageController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }


        [HttpPost]
        public async Task<IActionResult> AddProductImage([FromBody] AddProductImageDto addProductImageDto)
        {
            var response = await _productImageService.AddProductImage(addProductImageDto);

            return Ok(response);
        }

        [HttpDelete]
        [Route("{prductImageId:Guid}")]
        public async Task<IActionResult> DeleteProductImage([FromRoute] Guid prductImageId)
        {
            var response = await _productImageService.DeleteProductImage(prductImageId);

            return Ok(response);
        }

        [HttpGet("product/{productId:Guid}")]
        public async Task<IActionResult> GetProductsImagesbyProductId([FromRoute] Guid productId)
        {
            var response = await _productImageService.GetAllProdutsbyProductId(productId);
            return Ok(response);
        }

        [HttpPut]
        [Route("{productImageId:Guid}")]
        public async Task<IActionResult> UpdateProductImage([FromRoute] Guid productImageId, [FromBody] UpdateProductImageDto updateProductImageDto)
        {
            var response = await _productImageService.UpdateProductImage(productImageId, updateProductImageDto);

            return Ok(response);
        }

        [HttpGet("image/{ImageId:Guid}")]
        public async Task<IActionResult> GetProductImageById([FromRoute] Guid ImageId)
        {
            var response = await _productImageService.GetImageById(ImageId);
            return Ok(response);
        }
    }
}
