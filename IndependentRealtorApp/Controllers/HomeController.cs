using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;


namespace IndependentRealtorApp.Controllers
{
    public class HomeController : Controller
    {
        //inject IProperty instead of DbContext
        private IProperty _property;
        public HomeController(IProperty property) => _property = property;

        public IActionResult Index()
        {
            var property = _property.GetProperties();
            return View(property);
        }
    }
}
