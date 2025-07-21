using CommerceCraft.Api.Data;
using CommerceCraft.Api.Dto.AnalyticsDTO;
using CommerceCraft.Api.Interface.Repository;
using Microsoft.EntityFrameworkCore;

namespace CommerceCraft.Api.Repository
{
    public class SQLAnalyticsRepository : IAnalyticsRepository
    {
        private readonly AppDbContext _dbContext;

        public SQLAnalyticsRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CountActiveUsersAsync()
        {
            var count = await _dbContext.Users.Where(u => !u.IsDeleted && u.Role == 0).CountAsync();

            return count;
        }

        public async Task<List<BestSellingProductDto>> GetBestsellingProductsByQuantityAsync()
        {
            var products = await _dbContext.OrderItems
                            .GroupBy(u => u.ProductId)
                            .Select(g => new BestSellingProductDto
                            {
                                ProductId = g.Key,
                                QuantitySold = g.Sum(i => i.Quantity)
                            })
                            .OrderByDescending(x => x.QuantitySold)
                            .ToListAsync();

            return products;
        }

        public async Task<List<GetHighestRevenueProductDto>> GetHighestRevenueProductAsync()
        {
            var products = await _dbContext.OrderItems.GroupBy(p => p.ProductId)
                            .Select( g => new GetHighestRevenueProductDto
                            {
                                ProductId = g.Key,
                                Revenue = g.Sum(x =>x.TotalPriceAfterDiscount)
                            }).OrderByDescending(x => x.Revenue).ToListAsync();
            
            return products;
        }
    }
}
