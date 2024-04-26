using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using IndependentRealtorApp.Models;
using IndependentRealtorApp.Models.DomainModels﻿;

namespace IndependentRealtorApp.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<Realtor> userManager;
        private SignInManager<Realtor> signInManager;

        // constructor
        public AccountController(UserManager<Realtor> userMgr, SignInManager<Realtor> signInMgr)
        {
            this.userManager = userMgr;
            this.signInManager = signInMgr;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
