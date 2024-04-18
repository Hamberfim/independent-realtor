
using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace IndependentRealtorApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        //inject IProperty instead of DbContext
        private IProperty _property;
        public HomeController(IProperty property) => _property = property;

        //[Route("admin/Home")]
        public IActionResult Index()
        {
            var property = _property.GetProperties();
            return View(property);
        }


    }
}
