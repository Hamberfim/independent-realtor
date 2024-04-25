using IndependentRealtorApp.Area.Admin.Models;
using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace IndependentRealtorApp.Controllers
{
    public class PropertyController : Controller
    {
        //private readonly IProperty _propertyRepository;

        //public PropertyController(IProperty propertyRepository)
        //{
        //    _propertyRepository = propertyRepository;
        //}


        //public IActionResult Details(int id, string title)
        //{
        //    var property = _propertyRepository.GetPropertyById(id);

        //    if (property == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(property);
        //}


        //   no longer have IProperty, so we need to use PropertyService
        private readonly PropertyService _propertyService;

        public PropertyController(PropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        public IActionResult Details(int id, string title)
        {
            var property = _propertyService.GetPropertyById(id);

            if (property == null)
            {
                return NotFound();
            }

            return View(property);
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
