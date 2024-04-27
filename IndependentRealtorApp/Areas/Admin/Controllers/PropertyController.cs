using IndependentRealtorApp.Area.Admin.Models;
using IndependentRealtorApp.Models.DataLayer;
using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IndependentRealtorApp.Area.Admin.Controllers
{
    // [Authorize(Roles = "Admin")]
    // [Authorize]
    [Area("Admin")]
    public class PropertyController : Controller
    {
        private readonly PropertyService _propertyService;

        public PropertyController(PropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        
        public IActionResult Index()
        {
            var properties = _propertyService.GetProperties();
            return View(properties);

        }

        [HttpGet]
        public IActionResult Add(int? id)
        {
            if (id.HasValue)
            {
                var property = _propertyService.GetPropertyById(id.Value);
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
            property.ImageUrl = string.IsNullOrEmpty(property.ImageUrl) ? "...to come." : property.ImageUrl;

            if (ModelState.IsValid)
            {
                if (property.Id == 0)
                {
                    _propertyService.AddProperty(property);
                }
                else
                {
                    _propertyService.UpdateProperty(property);
                }
                return RedirectToAction("Index", "Property");
            }
            return View("AddEdit", property);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                var property = _propertyService.GetPropertyById(id.Value);
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
            var property = _propertyService.GetPropertyById(id);
            if (property != null)
            {
                _propertyService.DeleteProperty(id);
            }
            return RedirectToAction("Index");
        }
    }
}