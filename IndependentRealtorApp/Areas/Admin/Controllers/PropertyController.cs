﻿using IndependentRealtorApp.Models;
using IndependentRealtorApp.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IndependentRealtorApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PropertyController : Controller
    {
        //private readonly RealtorContext _context;
        //public PropertyController(RealtorContext context) => _context = context;

        // inject IProperty instead of DbContext
        private IProperty _property;
        public PropertyController(IProperty property) => _property = property;

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View("AddEdit", new Property());
        }

        [HttpPost]
        public IActionResult Add(Property property)
        {

            if (ModelState.IsValid)
            {
                if (property.PropertyId == 0)
                {
                    //_context.Properties.Add(property);
                    _property.Add(property);
                }
                else
                {
                    //_context.Properties.Update(property);
                    _property.Update(property);

                }

                // _context.SaveChanges();
                // return View("Index");  //not routing to the right location
                return RedirectToAction("Index", "Home");  
            }
            return View("AddEdit", property);
        }
    }
}
