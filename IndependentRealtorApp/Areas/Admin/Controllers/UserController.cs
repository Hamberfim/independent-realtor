using IndependentRealtorApp.Models;
using IndependentRealtorApp.Models.DataLayer;
using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IndependentRealtorApp.Areas.Admin.Controllers
{
    // [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class UserController : Controller
    {
        private UserManager<PublicUser> userManager;

        // private RoleManager<IdentityRole> roleManager;
        private RoleManager<ApplicationRole> roleManager;

        public UserController(UserManager<PublicUser> userMngr, RoleManager<ApplicationRole> roleMngr)
        {
            userManager = userMngr;
            roleManager = roleMngr;
        }

        public async Task<IActionResult> Index()
        {
            List<PublicUser> users = new List<PublicUser>();
            foreach (PublicUser user in userManager.Users)
            {
                user.RoleNames = await userManager.GetRolesAsync(user);
                users.Add(user);
            }
            UserViewModel model = new UserViewModel
            {
                Users = users,
                Roles = roleManager.Roles
            };
            return View(model);
        }

        
    }
}