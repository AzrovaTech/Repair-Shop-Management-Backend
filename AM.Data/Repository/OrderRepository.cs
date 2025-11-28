using AM.Data.Context;
using AM.Domain.Entities.Order;
using AM.Domain.IRepository;
using Microsoft.EntityFrameworkCore;

namespace AM.Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AMContext _context;

        public OrderRepository(AMContext context)
        {
            _context = context;
        }

        public async Task DeleteOrder(Order order)
        {
            _context.Orders.Remove(order);
        }

        public async Task<Order> GetOrderById(string orderId)
        {
            Order result = await _context.Orders.FirstOrDefaultAsync(o => o.OrderId == orderId);
            return result;
        }

        public async Task<IQueryable<Order>> GetOrderByName(string name)
        {
            IQueryable<Order> result = _context.Orders.Where(u => u.OrderName.Contains(name))
                .OrderByDescending(u => u.RecieveDate);

            return result;
        }

        public async Task<IQueryable<Order>> GetOrders()
        {
            return _context.Orders.Include(o => o.Customer).OrderByDescending(u => u.RecieveDate);
        }

        public async Task<IQueryable<Order>> GetOrdersByCustomerId(string customerId)
        {
            return _context.Orders.Include(o => o.Customer).Where(o => o.CustomerId == customerId);
        }

        public async Task InsertOrder(Order order)
        {
            await _context.Orders.AddAsync(order);
        }

        public async Task SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task UpdateOrder(Order order)
        {
            _context.Update(order);
        }
    }
}
