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
            ViewBag.msg = "<h2>Welcome to my page </h2>\n" +
                "<p>Please select an option in the menu above</p>";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.msg = "<h2>About Me </h2>\n" +
                "<div>" +
                "<h4> Fast facts: </h4>\n" +
                "<ul>" +
                "<li>Name: Magnus</li>" +
                "<li>Age: 42 years</li>\n" +
                "<li>Height: 185-ish cm</li>\n" +
                "</ul>" +
                "</div>";
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.msg = " < h2 > Contact </ h2 >\n" +
                "<div>" +
                "<p> Phone: \t<a href=\"tel: +46703011271\">070-30 11 271</a></p>\n" +
                "<p> E-mail:\t<a href=\"mailto: magbor@gmail.com\">magbor@gmail.com</a></p>\n" +
                "</div>";

            return View();
        }

        public IActionResult Projects()
        {
            ViewBag.msg = " alla ett preojekt";
            return View();
        }


    }
}
