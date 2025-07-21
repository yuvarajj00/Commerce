using CommerceCraft.Api.Interface.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CommerceCraft.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalyticsController : ControllerBase
    {
        private readonly IAnalyticsService _analyticsService;

        public AnalyticsController(IAnalyticsService analyticsService)
        {
            _analyticsService = analyticsService;
        }

        [HttpGet("Active-Users")]
        public async Task<IActionResult> GetActiveCustomerCount()
        {
            var response = await _analyticsService.CountActiveUsers();
            return Ok(response);
        }

        [HttpGet("GetBestSellingProducts")]
        public async Task<IActionResult> GetBestSellingProducts()
        {
            var response = await _analyticsService.GetBestSellingProducts();
            return Ok(response);
        }

        [HttpGet("GetHighestSellingProducts")]

        public async Task<IActionResult> GetHighestSellingProducts()
        {
            var response = await _analyticsService.GetHighestRevenueProducts();
            return Ok(response);
        }
    }
}
