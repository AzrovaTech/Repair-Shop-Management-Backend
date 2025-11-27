using AM.Core.DTOs.Customers;
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
/*
        public ActionResult AddCustomer(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(AddCustomerDTO addCustomer)
        {

            _orderService.AddCustomer(addCustomer);

            return RedirectToAction(nameof(Index));
        }

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
