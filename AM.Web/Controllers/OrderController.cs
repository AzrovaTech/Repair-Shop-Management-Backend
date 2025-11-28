using AM.Core.DTOs.Customers;
using AM.Core.DTOs.Orders;
using AM.Core.IServices;
using Microsoft.AspNetCore.Mvc;

namespace AM.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public ActionResult Index()
        {
            var result = _orderService.GetAllOrders().Result;
            return View(result);
        }

        public ActionResult AddOrder(string customerId)
        {
            var result = _orderService.GetAddOrderData(customerId).Result;
            return View(result);
        }

        [HttpPost]
        public ActionResult AddOrder(AddOrderDTO addOrder)
        {
            _orderService.AddOrder(addOrder);

            return RedirectToAction(nameof(Index));
        }
/*
        public ActionResult CustomerDetails(int id)
        {
            return View();
        }

        public ActionResult EditCustomer(string customerId)
        {
            EditCustomerDTO customer = _orderService.GetCustomerEditById(customerId).Result;
            return View(customer);
        }

        [HttpPost]
        public ActionResult EditCustomer(EditCustomerDTO customer)
        {
            _orderService.EditCustomer(customer);
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public ActionResult DeleteCustomer(string customerId)
        {
            _orderService.DeleteCustomer(customerId);
            return RedirectToAction(nameof(Index));
        }*/
    }
}
