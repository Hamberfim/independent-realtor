using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace IndependentRealtorApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PropertyController : Controller
    {
        //inject IProperty instead of DbContext
        private IProperty _property;
        public PropertyController(IProperty property) => _property = property;

        [Route("[area]/Property")]
        public IActionResult Index()
        {
            var property = _property.GetProperties();
            return View(property);

        }


        [HttpGet]
        public IActionResult Add(int? id)
        {
            if (id.HasValue)
            {
                var property = _property.GetPropertyById(id.Value);
                if (property != null)
                {
                    return View("AddEdit", property);
                }
            }
            return View("AddEdit", new Property());
        }

        [HttpPost]
        public IActionResult Add(Property property)
        {
            property.ImageUrl = string.IsNullOrEmpty(property.ImageUrl) ? "none" : property.ImageUrl;

            if (ModelState.IsValid)
            {
                if (property.PropertyId == 0)
                {
                    //_context.Properties.Add(property);
                    _property.Add(property);
                }
                else
                {
                    //_context.Properties.Update(property);
                    _property.Update(property);

                }

                // _context.SaveChanges();
                // return View("Index");  //not routing to the right location
                return RedirectToAction("Index", "Property");
            }
            return View("AddEdit", property);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                var property = _property.GetPropertyById(id.Value);
                if (property != null)
                {
                    return View(property);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var property = _property.GetPropertyById(id);
            if (property != null)
            {
                //_context.Properties.Remove(property);
                _property.Delete(property);
                //_context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
