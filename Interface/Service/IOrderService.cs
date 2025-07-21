using CommerceCraft.Api.Dto;
using CommerceCraft.Api.Dto.OrderDTO;

namespace CommerceCraft.Api.Interface.Service
{
    public interface IOrderService
    {
        Task<ApiResponseDto<List<OrderDto>>> GetAllOrders();

        Task<ApiResponseDto<OrderDto>> UpdateOrderStatus(Guid orderId, StatusDto statusDto);


    }
}
