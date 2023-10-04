﻿namespace StaticDemoTemperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string selection = String.Empty;
            while (selection != "q" && selection != "Q" )
            {
                Console.WriteLine("Enter C)elsius to Farenheit or\nF)arenheit to Celsius or\nK)elvin to Celsius or\nQ)uit");
                selection = Console.ReadLine();
                double farenheit, celsius = 0;

                switch (selection)
                {
                    case "C":
                    case "c":
                        Console.Write("Please enter the Celsius temperature: ");
                        farenheit = Helper.CelsiusToFahrenheit(Console.ReadLine());
                        Console.WriteLine($"Temperature in Fahrenheit: {farenheit:f2}\n");
                        break;

                    case "F":
                    case "f":
                        Console.WriteLine("Please enter the Fahrenheit temperature:");
                        celsius = TempConverter.FahrenheitToCesius(Console.ReadLine());
                        Console.WriteLine($"Temperature in Celsius: {celsius:f2}\n");
                        break;

                    case "K":
                    case "k":

                        Console.WriteLine("Please enter Kelvin temperature: ");
                        celsius = TempConverter.KelvinToCelsius(Console.ReadLine());
                        Console.WriteLine($"Temperature in Celsius: {celsius:f2}\n");
                        break;

                    case "Q":
                    case "q":
                        Console.WriteLine("See you next time");
                        break;

                    default:
                        Console.WriteLine("Please try again");
                        break;
                }


            }
        }
    }
}