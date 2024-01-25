using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5.0 / 9;
            
        }
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9.0 / 5) + 32;
            
        }
        




    }
}
