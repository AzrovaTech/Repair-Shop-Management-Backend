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

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public ActionResult Index()
        {
            var result = _customerService.GetAllCustomers().Result;
            return View(result);
        }
        
        public ActionResult AddCustomer(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(AddCustomerDTO addCustomer)
        {

            _customerService.AddCustomer(addCustomer);

            return RedirectToAction(nameof(Index));
        }

        public ActionResult CustomerDetails(int id)
        {
            return View();
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
