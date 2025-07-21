using AutoMapper;
using CommerceCraft.Api.Dto;
using CommerceCraft.Api.Dto.AnalyticsDTO;
using CommerceCraft.Api.Interface.Repository;
using CommerceCraft.Api.Interface.Service;

namespace CommerceCraft.Api.Service
{
    public class AnalyticsService : IAnalyticsService
    {
        private readonly IMapper _mapper;
        private readonly IAnalyticsRepository _analyticsRepository;

        public AnalyticsService(IMapper mapper,IAnalyticsRepository analyticsRepository)
        {
            this._mapper = mapper;
            this._analyticsRepository = analyticsRepository;
        }

        public async Task<ApiResponseDto<int>> CountActiveUsers()
        {
            var count = await _analyticsRepository.CountActiveUsersAsync();

            var NewResponse = new ApiResponseDto<int>()
            {
                Success = true,
                Message = "Total Active Users",
                Data = count
            };
            return NewResponse;

        }

        public async Task<ApiResponseDto<List<BestSellingProductDto>>> GetBestSellingProducts()
        {
            var products = await _analyticsRepository.GetBestsellingProductsByQuantityAsync();

            var NewResponse = new ApiResponseDto<List<BestSellingProductDto>>()
            {
                Success = true,
                Message = "Best 10 Selling Products",
                Data = products
            };
            return NewResponse;
        }

        public async Task<ApiResponseDto<List<GetHighestRevenueProductDto>>> GetHighestRevenueProducts()
        {
            var HighestRevenueProducts = await _analyticsRepository.GetHighestRevenueProductAsync();

            var newResponse = new ApiResponseDto<List<GetHighestRevenueProductDto>>()
            {
                Success = true,
                Message = "Highest Revenue Products",
                Data = HighestRevenueProducts
            };
            return newResponse;
        }
    }
}
