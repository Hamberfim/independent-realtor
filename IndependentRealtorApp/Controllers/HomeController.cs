using IndependentRealtorApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace IndependentRealtorApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly RealtorContext _context;

        // dependency injection
        public HomeController(RealtorContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
