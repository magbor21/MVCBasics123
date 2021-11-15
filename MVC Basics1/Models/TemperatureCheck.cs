using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics1.Models
{
    public static class Temperaturecheck
    {

        public static string TempCheck(float temp)
        {
                       
            if (temp > 50)
                return FarenheitFever(temp); // more than 50 degrees celcius 
            else
                return CelciusFever(temp);   // and less then 50 degrees farenheit
                                                  
        }                                    // usually means that you are dead. 

        private static string CelciusFever(float temp) 
        {
            if (temp < 32)
                return "You have severe hypothermia";
            else if (temp < 36)
                return "You have mild hypothermia";
            else if (temp > 39.9)
                return "You have severe fever";
            else if (temp > 37.9)
                return "You have a mild fever";
            else
                return "Your temperature is normal";
            
        }

        private static string FarenheitFever(float temp) // F = C * 1,6 + 32
        {
            if (temp < 89.6)
                return "You have severe hypothermia";
            else if (temp < 96.8)
                return "You have mild hypothermia";
            else if (temp > 103.8)
                return "You have severe fever";
            else if (temp > 100)
                return "You have a mild fever";
            else
                return "Your temperature is normal";
        }
    }
}
