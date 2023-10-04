using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemoTemperature
{
    public class TempConverter
    {
        public static double FahrenheitToCesius(String tempFahrenheit)
        {
            double fahrenheit = Double.Parse(tempFahrenheit);
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;

        }
        public static double KelvinToCelsius(string tempKelvin)
        {
            double kelvin = Double.Parse(tempKelvin);
            double celsius = kelvin - 273.15;
            return celsius;
        }
    }
}
