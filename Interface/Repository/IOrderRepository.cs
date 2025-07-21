using CommerceCraft.Api.Data;

namespace CommerceCraft.Api.Interface.Repository
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllOrdersAsync();

        Task<Order?> UpdateOrderStatusAsync(Guid orderId,Order order);
    }
}
