using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson10_2
{
    static class Converter
    {
        public static double CelsiusToFahrenheit(double temperatureCelsius)
        {
            return (temperatureCelsius * 9 / 5) + 32; 
        }
        public static double FahrenheitToCelsius(double temperatureFahrenheit)
        {
            return (temperatureFahrenheit - 32) * 5 / 9;
        }
    }
}
