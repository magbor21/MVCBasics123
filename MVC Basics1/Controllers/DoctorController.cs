using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Basics1.Models;

namespace MVC_Basics1.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult FeverCheck()
        {

            ViewBag.result = "Please enter your current temperature";
            ViewBag.lastTemp = 37; //returns a start value

            return View();
        }


        [HttpPost]
        public IActionResult FeverCheck(string Temperature)
        {
            
            float tempFloat = float.Parse(Temperature.Replace('.',',')); // The system prefers commas as decimal points.
            ViewBag.result = Temperaturecheck.TempCheck(tempFloat);
            ViewBag.lastTemp = tempFloat;
            return View();
        }
    }
}

