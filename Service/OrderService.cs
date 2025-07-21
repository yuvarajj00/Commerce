using AutoMapper;
using CommerceCraft.Api.Data;
using CommerceCraft.Api.Dto;
using CommerceCraft.Api.Dto.OrderDTO;
using CommerceCraft.Api.Interface.Repository;
using CommerceCraft.Api.Interface.Service;

namespace CommerceCraft.Api.Service
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;

        public OrderService(IMapper mapper,IOrderRepository orderRepository)
        {
            this._mapper = mapper;
            this._orderRepository = orderRepository;
        }
        public async Task<ApiResponseDto<List<OrderDto>>> GetAllOrders()
        {
            var AllOrdersModel = await _orderRepository.GetAllOrdersAsync();

            var AllOrdersDto = _mapper.Map<List<OrderDto>>(AllOrdersModel);

            var NewResponse = new ApiResponseDto<List<OrderDto>>()
            {
                Success = true,
                Message = "Orders Fetched Successfully",
                Data = AllOrdersDto
            };

            return NewResponse;
        }

        public async Task<ApiResponseDto<OrderDto>> UpdateOrderStatus(Guid orderId,StatusDto statusDto)
        {
            var StatusModel = _mapper.Map<Order>(statusDto);

            StatusModel = await _orderRepository.UpdateOrderStatusAsync(orderId, StatusModel);

            var updatedStatusOrderDto = _mapper.Map<OrderDto>(StatusModel);

            var NewResponse = new ApiResponseDto<OrderDto>()
            {
                Success = true,
                Message = "Order status updated",
                Data = updatedStatusOrderDto
            };

            return NewResponse;
        }
    }
}
