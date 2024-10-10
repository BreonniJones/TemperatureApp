using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using operationsLibrary;

namespace operationsApplication
{
    public class PerformTemperatureConversion
    {
        public void ConvertTemperature()
        {
            Console.WriteLine("Temperature Conversion App");
            Console.WriteLine("Select conversion type:");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter temperature in Celsius:");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = TemperatureConverter.CelsiusToFahrenheit(celsius);
                Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter temperature in Fahrenheit:");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = TemperatureConverter.FahrenheitToCelsius(fahrenheit);
                Console.WriteLine($"Temperature in Celsius: {celsius}");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
