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
            
           

            return View();
        }


        [HttpPost]
        public IActionResult FeverCheck(string Temperature)
        {
            
            float tempFloat = float.Parse(Temperature.Replace('.',','));
            ViewBag.result = Temperaturecheck.TempCheck(tempFloat); 
            return View();
        }
    }
}

