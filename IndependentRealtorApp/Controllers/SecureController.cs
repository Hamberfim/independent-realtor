using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IndependentRealtorApp.Controllers
{
    [Authorize]
    public class SecureController : Controller
    {
        public SecureController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        //[AllowAnonymous]
        //public IActionResult Evan()
        //{
        //    return View();
        //}
    }
}
