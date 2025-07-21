using CommerceCraft.Api.Dto;
using CommerceCraft.Api.Dto.AnalyticsDTO;

namespace CommerceCraft.Api.Interface.Service
{
    public interface IAnalyticsService
    {
        Task<ApiResponseDto<int>> CountActiveUsers();

        Task<ApiResponseDto<List<BestSellingProductDto>>> GetBestSellingProducts();

        Task<ApiResponseDto<List<GetHighestRevenueProductDto>>> GetHighestRevenueProducts();
    }
}
