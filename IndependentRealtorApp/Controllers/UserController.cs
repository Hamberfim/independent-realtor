using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace IndependentRealtorApp.Controllers
{
    public class UserController : Controller
    {
        // inject IUser instead of DbContext
        private IUser _user;
        public UserController(IUser user) => _user = user;

        public IActionResult Index()
        {
            var users = _user.GetUsers();
            return View(users);
        }


            return RedirectToAction(nameof(Index));
        }
    }
}
