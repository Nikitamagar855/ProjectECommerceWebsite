using Microsoft.AspNetCore.Mvc;
using ProjectECommerceWebsite.Data;
using ProjectECommerceWebsite.Models;
using System.Linq;


namespace ProjectECommerceWebsite.Controllers
{
    public class Customer : Controller
    {
        private readonly ApplicationDbContext context;
        
        public Customer(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var l = context.Inventry.ToList();
            ViewBag.Products = l;
            return View(l);
        }
        public IActionResult Order()
        {
            return View();
        }
    }
}
