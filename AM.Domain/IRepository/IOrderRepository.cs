using AM.Domain.Entities.Order;

namespace AM.Domain.IRepository
{
    public interface IOrderRepository
    {
        public Task<IQueryable<Order>> GetOrders();

        public Task<Order> GetOrderById(string orderId);

        public Task<IQueryable<Order>> GetOrderByName(string name);

        public Task InsertOrder(Order order);

        public Task UpdateOrder(Order order);

        public Task DeleteOrder(Order order);
    }
}
