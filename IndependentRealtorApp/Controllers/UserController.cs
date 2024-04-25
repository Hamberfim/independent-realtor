using IndependentRealtorApp.Models.DataLayer;
using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IndependentRealtorApp.Controllers
{
    public class UserController : Controller
    {
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
    }
}