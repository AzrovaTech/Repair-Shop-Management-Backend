using AM.Core.DTOs.Customers;
using AM.Core.IServices;
using AM.Domain.Entities.Customer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AM.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IOrderService _orderService;

        public CustomerController(ICustomerService customerService, IOrderService orderService)
        {
            _customerService = customerService;
            _orderService = orderService;
        }

        public ActionResult Index()
        {
            var result = _customerService.GetAllCustomers().Result;
            return View(result);
        }
        
        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(AddCustomerDTO addCustomer)
        {
            _customerService.AddCustomer(addCustomer);

            return RedirectToAction(nameof(Index));
        }

        public ActionResult CustomerDetails(string customerId)
        {
            var result = _orderService.GetOrdersByCustomerId(customerId).Result;
            return View(result);
        }

        public ActionResult EditCustomer(string customerId)
        {
            EditCustomerDTO customer = _customerService.GetCustomerEditById(customerId).Result;
            return View(customer);
        }

        [HttpPost]
        public ActionResult EditCustomer(EditCustomerDTO customer) 
        {
            _customerService.EditCustomer(customer);
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public ActionResult DeleteCustomer(string customerId)
        {
            _customerService.DeleteCustomer(customerId);
            return RedirectToAction(nameof(Index));
        }
    }
}
