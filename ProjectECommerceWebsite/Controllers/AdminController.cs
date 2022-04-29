using Microsoft.AspNetCore.Mvc;

namespace ProjectECommerceWebsite.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }
        public IActionResult ProductList()
        {
            return View();
        }
    }
}
