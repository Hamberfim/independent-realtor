using Microsoft.AspNetCore.Mvc;
using IndependentRealtorApp.Models.DomainModels;

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
    		public IActionResult Add()
		{
			return View(); // This will render the "Add.cshtml" view
		}

    }
}
