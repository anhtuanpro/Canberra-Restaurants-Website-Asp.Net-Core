using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CanberraRestaurants.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Restaurants()
        {
            return View();
        }

        public IActionResult Cuisine()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Dishes()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Prices()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Location()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Reviews()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
