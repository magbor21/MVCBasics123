using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Basics1.Models;
using Microsoft.AspNetCore.Http;

namespace MVC_Basics1.Controllers
{
    public class GuessController : Controller
    {
        public IActionResult GuessingGame()
        {
            HttpContext.Session.SetString("CurrentGame", "The current game"); //New session
            string respond = GuessingSession.NewSession();

            ViewBag.lowest = respond.Substring(0, 3);  //"001,___,__,___"; 
            ViewBag.highest = respond.Substring(4, 3); //"___,100,__,___";
            ViewBag.guesses = respond.Substring(8, 2); //"___,___,00,___";
            ViewBag.result = "Guess a number between 1 and 100";

            return View();
            
        }


        [HttpPost]
        public IActionResult GuessingGame(string Guesses)
        {
            string sessionActive = HttpContext.Session.GetString("CurrentGame");
            if (sessionActive != null)
            {                    
                string response = GuessingSession.Guess(Int32.Parse(Guesses));

                if (response[12] == 'o') // No, not New
                    ViewBag.result = "Try again";

                if(response[11] == 'L') //Low
                    ViewBag.result = "Your guess was a bit low. Please guess a higher number";

                if (response[11] == 'H') //High
                    ViewBag.result = "Your guess was a little high. Please guess a lower number";

                if (response[11] == 'Y') //YES!
                { 
                    ViewBag.result = "You guessed the correct number (" + Int32.Parse(response.Substring(0, 3)) + " in " + Int32.Parse(response.Substring(8, 2)) + " number of tries! ";
                    HttpContext.Session.Clear(); //Remove("CurrentGame");
                }
                     


                ViewBag.lowest = response.Substring(0, 3);  //"001,___,__,___";  // Splits the return string into more managable bits
                ViewBag.highest = response.Substring(4, 3); //"___,100,__,___";
                ViewBag.guesses = response.Substring(8, 2); //"___,___,00,___";
                
            }
            else
                return RedirectToAction("GuessingGame"); // Requests a new game if there is no active game
              
            return View();
        }

        
        
    }
}

