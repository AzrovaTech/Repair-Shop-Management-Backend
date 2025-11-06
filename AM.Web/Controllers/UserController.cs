using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AM.Web.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult AddUser(int id)
        {
            return View();
        }

        public ActionResult UserDetails(int id)
        {
            return View();
        }

        public ActionResult EditUser(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult DeleteUser(int userId)
        {
            Console.WriteLine("User Id : " + userId);
            return RedirectToAction(nameof(Index));
        }
    }
}
