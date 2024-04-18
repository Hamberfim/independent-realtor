using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace IndependentRealtorApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private IProperty _property;
        public HomeController(IProperty property) => _property = property;

        public IActionResult Index()
        {
            var property = _property.GetProperties();
            return View(property);
        }

       // placeholder methods for Add, Update, and Delete
        public IActionResult Add() => View();
        public IActionResult Update(int id)
        {
            var property = _property.GetPropertyById(id);
            return View(property);
        }
        public IActionResult Delete(int id)
        {
            var property = _property.GetPropertyById(id);
            return View(property);
        }
    }
}
