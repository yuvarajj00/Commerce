using CommerceCraft.Api.Data;
using CommerceCraft.Api.Interface.Repository;
using Microsoft.EntityFrameworkCore;

namespace CommerceCraft.Api.Repository
{
    public class SQLOrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;

        public SQLOrderRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Order>> GetAllOrdersAsync()
        {
            var AllOrders = await _context.Orders.ToListAsync();
            return AllOrders;
        }

        public async Task<Order?> UpdateOrderStatusAsync(Guid orderId, Order order)
        {
            var updateOrder = await _context.Orders.FirstOrDefaultAsync(o => o.OrderId == orderId);

            updateOrder.Status = order.Status;
            updateOrder.ModifiedDate = DateTime.Now;
            updateOrder.ModifiedBy = 0;

            await _context.SaveChangesAsync();

            return updateOrder;

        }
    }
}
