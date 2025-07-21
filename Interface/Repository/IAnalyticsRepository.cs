using CommerceCraft.Api.Data;
using CommerceCraft.Api.Dto.AnalyticsDTO;

namespace CommerceCraft.Api.Interface.Repository
{
    public interface IAnalyticsRepository
    {
        Task<int> CountActiveUsersAsync();

        Task<List<BestSellingProductDto>> GetBestsellingProductsByQuantityAsync();

        Task<List<GetHighestRevenueProductDto>> GetHighestRevenueProductAsync();


    }
}
