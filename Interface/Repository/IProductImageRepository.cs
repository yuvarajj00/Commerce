using CommerceCraft.Api.Data;

namespace CommerceCraft.Api.Interface.Repository
{
    public interface IProductImageRepository
    {
        Task<ProductImage> AddProductImageAsync(ProductImage image);

        Task<ProductImage> UpdateProductImageAsync(Guid productImageId, ProductImage image);

        Task<ProductImage> DeleteProductImageAsync(Guid productImageId);

        Task<List<ProductImage>> GetAllProductImagesByProductIdAsync(Guid productId);

        Task<ProductImage> GetProductImagebyIdAsync(Guid productImageId);

    }
}
