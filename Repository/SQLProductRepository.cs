using CommerceCraft.Api.Data;
using CommerceCraft.Api.Interface.Repository;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CommerceCraft.Api.Repository
{
    public class SQLProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public SQLProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Product> AddProductAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return await _context.Products.Include("Category").FirstOrDefaultAsync(i => i.ProductId == product.ProductId);

        }

        public async Task DeleteProductAsync(Guid productId)
        {
            var toDeleteProduct = await _context.Products.FirstOrDefaultAsync(i => i.ProductId == productId);

            toDeleteProduct.IsDeleted = true;
            toDeleteProduct.ModifiedDate = DateTime.Now;
            toDeleteProduct.ModifiedBy = 0;
            

            await _context.SaveChangesAsync();

            
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products.Where(p => !p.IsDeleted).Include(p=>p.ProductImages).Include("Category").ToListAsync();
        }

        public async Task<Product?> GetProductByIdAsync(Guid productId)
        {
            var fetchedProduct = await _context.Products.Include(p=>p.Category).Include(p=> p.ProductImages).FirstOrDefaultAsync(p => p.ProductId == productId);

            return fetchedProduct;
        }

        public async Task<Product?> UpdateProductAsync(Guid productId, Product product)
        {
           var toUpdateProduct = await _context.Products.FirstOrDefaultAsync(i => i.ProductId ==productId);

            if (toUpdateProduct == null)
            {
                return null;  
            }
            toUpdateProduct.Name = product.Name;
            toUpdateProduct.Description = product.Description;
            toUpdateProduct.OriginalPrice = product.OriginalPrice;
            toUpdateProduct.DiscountPercentage = product.DiscountPercentage;
            toUpdateProduct.StockQuantity = product.StockQuantity;
            toUpdateProduct.IsFeatured = product.IsFeatured;
            toUpdateProduct.CategoryId = toUpdateProduct.CategoryId;
            toUpdateProduct.ModifiedDate = DateTime.UtcNow;
            toUpdateProduct.ModifiedBy = 0;

            await _context.SaveChangesAsync();

            return toUpdateProduct;

    }

    }
}
