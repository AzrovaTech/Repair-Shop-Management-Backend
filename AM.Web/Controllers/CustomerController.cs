using AM.Core.IServices;
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

        public ActionResult CustomerDetails(int id)
        {
            return View();
        }

        public ActionResult EditCustomer(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult DeleteCustomer(int CustomerId)
        {
            Console.WriteLine("Customer Id : " + CustomerId);
            return RedirectToAction(nameof(Index));
        }
    }
}
