using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemoTemperature
{
    public class Helper
    {
        public static double CelsiusToFahrenheit(string tempCelsius)
        {
            double celsius = Double.Parse(tempCelsius);
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
    }
}
