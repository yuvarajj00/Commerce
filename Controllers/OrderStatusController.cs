using CommerceCraft.Api.Dto.OrderDTO;
using CommerceCraft.Api.Interface.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CommerceCraft.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderStatusController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderStatusController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            var response = await _orderService.GetAllOrders();
            return Ok(response);
        }

        [HttpPut]
        [Route("{orderId:Guid}")]
        public async Task<IActionResult> UpdateOrderStatus([FromRoute] Guid orderId,StatusDto statusDto)
        {
            var response = await _orderService.UpdateOrderStatus(orderId, statusDto);
            return Ok(response);
        }
    }
}
