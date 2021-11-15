using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics1.Models
{
    public static class GuessingSession //New Game
    {
        
        private static int targetNumber;
        private static int lowest = 1;
        private static int highest = 100;
        private static int guesses = 0;
        public static string NewSession()
        {
            lowest = 1;
            highest = 100;
            guesses = 0;
            Random random = new Random();
            targetNumber = random.Next(1, 101);

            string reply = "001,100,00,New"; //Returns all information in one string
            return reply;
        }


        public static string Guess(int number) //Guess
        {
            string reply = "No"; 
            if (number <= highest && number >= lowest) 
            {
                guesses++;

                if (number == targetNumber) 
                {
                    reply = "Yes";
                    lowest = number;
                    highest = number;
                }  
                else if (number < targetNumber) //Narrows the scope of available numbers
                {
                    lowest = number + 1;
                    reply = "Low";
                }
                else if (number > targetNumber) //Narrows the scope of available numbers
                {
                    highest = number - 1;
                    reply = "High";
                   
                }
                
            }

            return lowest.ToString("D3") + "," + highest.ToString("D3") + "," + guesses.ToString("D2") + "," + reply;
        }


    }
}
