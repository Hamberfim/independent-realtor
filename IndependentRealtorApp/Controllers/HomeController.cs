using IndependentRealtorApp.Models.DataLayer;
using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;


namespace IndependentRealtorApp.Controllers
{
    public class HomeController : Controller
    {
        private RealtorContext _context;
        public HomeController(RealtorContext ctx) => _context = ctx;

        public IActionResult Index()
        {
            var properties = GetProperties();
            return View(properties);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public List<Property> GetProperties()
        {
            return _context.Properties.ToList();
        }

    }
}
