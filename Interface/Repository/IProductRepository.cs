using CommerceCraft.Api.Data;

namespace CommerceCraft.Api.Interface.Repository
{
    public interface IProductRepository
    {
        Task<Product> AddProductAsync(Product product);

        Task<List<Product>> GetAllProductsAsync();

        Task<Product?> UpdateProductAsync(Guid productId,Product product);

        Task DeleteProductAsync(Guid productId);

        Task<Product?> GetProductByIdAsync(Guid productId);


    }
}
