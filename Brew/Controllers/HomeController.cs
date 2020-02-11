using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Brew.Models;
using Brew.Data;
using Microsoft.AspNetCore.Authorization;

namespace Brew.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;
        public HomeController(ApplicationDbContext _db)
        {
            db = _db;
        }
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        [Authorize]
        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
            {
                
                return View(db.Recipes.ToList());
            }
            else
            {
                return RedirectToAction("Login", "Account", "Identity");
            }
        }
        //public IActionResult SetRecipe(float Grind, float Dose, string Body, string Extraction)
        //{
        //    Recipe r = new Recipe(Dose, Grind, Body, Extraction);
        //    return View(StaticMethodLayer.GetNextRecipe(r));
        //}

        public IActionResult RecipeDetails(string origin, string roaster)
        {
            //search for existing recipe

            //if no recipe...
            double grind = 6;
            double dose = 25;
            Recipe newDial = new Recipe(origin, roaster, grind, dose);
            return View(newDial);
        }
        [HttpPost]
        public IActionResult NewCoffee(string origin, string roaster, double dose, double grind)
        {
            Recipe r = new Recipe(origin, roaster, dose, grind);
            r.UserId = User.Identity.Name;
            db.Add(r);
            db.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
