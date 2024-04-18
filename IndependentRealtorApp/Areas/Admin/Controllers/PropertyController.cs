using IndependentRealtorApp.Models;
using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace IndependentRealtorApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PropertyController : Controller
    {
        private RealtorContext _context;
        public PropertyController(RealtorContext context) => _context = context;

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View("AddEdit", new Property());
        }

        [HttpPost]
        public IActionResult Add(Property property)
        {

            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }
            return View("AddEdit", new Property());
        }
    }
}
