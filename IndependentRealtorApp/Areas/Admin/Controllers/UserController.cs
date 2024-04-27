using IndependentRealtorApp.Models;
using IndependentRealtorApp.Models.DataLayer;
using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IndependentRealtorApp.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    //[Authorize]
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

        [HttpPost]
        public async Task<IActionResult> CreateAdminRole()
        {
            var result = await roleManager.CreateAsync(new ApplicationRole("Admin"));
            if (result.Succeeded) { }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteRole(string id)
        {
            // look the role up
            ApplicationRole? role = await roleManager.FindByIdAsync(id);
            if (role != null)
            {
                var result = await roleManager.DeleteAsync(role);
                if (result.Succeeded) { }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> AddToAdmin(string id)
        {
            ApplicationRole? adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole == null || adminRole.Name == null)
            {
                TempData["message"] = "Admin role does not exist. Click 'Create Admin Role' button to create it.";
            }
            else
            {
                PublicUser? user = await userManager.FindByIdAsync(id);
                if (user != null)
                {
                    await userManager.AddToRoleAsync(user, adminRole.Name);
                }
                else
                {
                    TempData["message"] = "User not found.";
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromAdmin(string id)
        {
            PublicUser? user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                var result = await userManager.RemoveFromRoleAsync(user, "Admin");
                if (result.Succeeded) { }
            }
            else
            {
                TempData["message"] = "User not found.";
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new PublicUser { UserName = model.UserName };
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            PublicUser? user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await userManager.DeleteAsync(user);
                if (!result.Succeeded) // if failed
                {
                    string errorMessage = "";
                    foreach (IdentityError error in result.Errors)
                    {
                        errorMessage += error.Description + " | ";
                    }
                    TempData["message"] = errorMessage;
                }
            }
            return RedirectToAction("Index");
        }
    }
}