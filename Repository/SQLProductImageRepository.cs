using CommerceCraft.Api.Data;
using CommerceCraft.Api.Interface.Repository;
using Microsoft.EntityFrameworkCore;

namespace CommerceCraft.Api.Repository
{
    public class SQLProductImageRepository : IProductImageRepository
    {
        private readonly AppDbContext _context;

        public SQLProductImageRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ProductImage> AddProductImageAsync(ProductImage image)
        {
            await _context.ProductImages.AddAsync(image);
            await _context.SaveChangesAsync();
            return image;
        }

        public async Task<ProductImage> DeleteProductImageAsync(Guid productImageId)
        {
            var toDeletedImage = await _context.ProductImages.FirstOrDefaultAsync(i => i.ProductImageId == productImageId);

            _context.ProductImages.Remove(toDeletedImage);
            await _context.SaveChangesAsync();
            return toDeletedImage;
        }

        public async Task<List<ProductImage>> GetAllProductImagesByProductIdAsync(Guid productId)
        {
            var AllProdctImages = await _context.ProductImages.Where(i => i.ProductId == productId).ToListAsync();
            return AllProdctImages;
        }

        public async Task<ProductImage> UpdateProductImageAsync(Guid productImageId, ProductImage image)
        {
            var ToUpdateImage = await _context.ProductImages.FirstOrDefaultAsync(i => i.ProductImageId == productImageId);

            ToUpdateImage.ProductId = image.ProductId;
            ToUpdateImage.ImageName = image.ImageName;
            ToUpdateImage.ImageUrl = image.ImageUrl;
            ToUpdateImage.IsThumbnail = image.IsThumbnail;

            await _context.SaveChangesAsync();
            return ToUpdateImage;
        }

        public async Task<ProductImage> GetProductImagebyIdAsync(Guid productImageId)
        {
            return await _context.ProductImages.FirstOrDefaultAsync(i => i.ProductImageId == productImageId);
        }
    }
}
