using IndependentRealtorApp.Models.DataLayer;
using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IndependentRealtorApp.Controllers
{
    public class UserController : Controller
    {
        // Not using IUser, replaced code

        private RealtorContext _context;
        public UserController(RealtorContext ctx) => _context = ctx;



        public IActionResult Index()
        {
            var users = _context.PublicUsers.ToList();
            return View(users);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(PublicUser user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);

        }
    }
}