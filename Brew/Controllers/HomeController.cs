using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Brew.Models;
using Brew.Data;

namespace Brew.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SetRecipe(float Grind, float Dose, string Body, string Extraction)
        {
            Recipe r = new Recipe(Dose, Grind, Body, Extraction);
            return View(StaticMethodLayer.GetNextRecipe(r));
        }

        public IActionResult NewCoffee()
        {
            if(User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("./Identity/Account/Login");
            }
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
