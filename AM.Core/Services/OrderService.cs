using AM.Core.DTOs.Orders;
using AM.Core.IServices;
using AM.Core.Tools;
using AM.Domain.Entities.Order;
using AM.Domain.IRepository;

namespace AM.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICustomerRepository _customerRepository;

        public OrderService(IOrderRepository orderRepository, ICustomerRepository customerRepository)
        {
            _orderRepository = orderRepository;
            _customerRepository = customerRepository;
        }

        public async Task<OrdersIndexDTO> GetAllOrders()
        {
            ICollection<Order> rawOrders = _orderRepository.GetOrders().Result.ToList();
            List<OrderTableDTO> orders = new List<OrderTableDTO>();

            foreach (var order in rawOrders)
            {
                orders.Add(new OrderTableDTO
                {
                    OrderId = order.OrderId,
                    Name = order.OrderName,
                    CustomerName = order.Customer.FullName,
                    RecieveDate = order.RecieveDate.ToPersian(),
                    Price = order.OrderPrice,
                    Status = order.OrderStatus
                });
            }

            OrdersIndexDTO result = new OrdersIndexDTO
            {
                Orders = orders
            };

            return result;
        }

        public async Task<COrdersIndexDTO> GetOrdersByCustomerId(string customerId)
        {
            ICollection<Order> rawOrders = _orderRepository.GetOrdersByCustomerId(customerId).Result.ToList();
            List<COrderTableDTO> orders = new List<COrderTableDTO>();

            foreach (var order in rawOrders)
            {
                orders.Add(new COrderTableDTO
                {
                    OrderId = order.OrderId,
                    Name = order.OrderName,
                    RecieveDate = order.RecieveDate.ToPersian(),
                    Price = order.OrderPrice,
                    Status = order.OrderStatus
                });
            }

            COrdersIndexDTO result = new COrdersIndexDTO
            {
                Orders = orders,
                CustomerName = _customerRepository.GetCustomerById(customerId).Result.FullName
            };

            return result;
        }
    }
}
