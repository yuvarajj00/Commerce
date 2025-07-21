using CommerceCraft.Api.Dto.ProductDTO;
using CommerceCraft.Api.Interface.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CommerceCraft.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] AddProductDto addProductDto)
        {
            var response = await _productService.AddProduct(addProductDto);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var response = await _productService.GetAllProducts();

            return Ok(response);
        }

        [HttpPut]
        [Route("{productId:Guid}")]
        public async Task<IActionResult> UpdateProduct([FromRoute] Guid productId,[FromBody] UpdateProductDto updateProductDto)
        {
            var response = await _productService.UpdateProduct(productId, updateProductDto);

            return Ok(response);
        }

        [HttpDelete]
        [Route("{productId:Guid}")]

        public async Task<IActionResult> DeleteProduct([FromRoute] Guid productId)
        {
            await _productService.DeleteProduct(productId);
            return Ok("Product deleted");
        }

        [HttpGet]
        [Route("{productId:Guid}")]

        public async Task<IActionResult> GetProduct([FromRoute] Guid productId)
        {
            var response = await _productService.GetProductDetilas(productId);

            return Ok(response);
        }
    }
}
