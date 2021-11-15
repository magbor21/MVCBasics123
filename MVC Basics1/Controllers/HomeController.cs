using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.headline = "Welcome to my page";
            ViewBag.text = "Please select an option in the menu above";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.name = "Magnus";
            ViewBag.age = "42 years old";
            ViewBag.height = "185-ish cm";
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.phone = "070-30 11 271";
            ViewBag.phoneInternational = "+46703011271";
            ViewBag.email = "magbor@gmail.com";

            return View();
        }

        public IActionResult Projects()
        {
            // Last minute addition in plain HTML. Sorry about that
            return View();
        }


    }
}
