using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace IndependentRealtorApp.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IProperty _propertyRepository;

        public PropertyController(IProperty propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        public IActionResult Details(int id, string title)
        {
            var property = _propertyRepository.GetPropertyById(id);

            if (property == null)
            {
                return NotFound();
            }

            return View(property);
        }
    }
}
