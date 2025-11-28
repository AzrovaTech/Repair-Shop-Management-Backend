
using AM.Core.DTOs.Orders;

namespace AM.Core.IServices
{
    public interface IOrderService
    {
        public Task<OrdersIndexDTO> GetAllOrders();

        public Task<COrdersIndexDTO> GetOrdersByCustomerId(string customerId);

        public Task<AddOrderDTO> GetAddOrderData(string customerId);

        public Task AddOrder(AddOrderDTO addOrder);


        /*        public Task<EditOrderDTO> GetOrderEditById(string OrderId);
                public Task EditOrder(EditOrderDTO editOrder);
                public Task DeleteOrder(string OrderId);*/
    }
}
