using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operationsApplication
{
    class TemperatureApp
    {
        static void Main(string[] args)
        {
            PerformTemperatureConversion conversion = new PerformTemperatureConversion();
            conversion.ConvertTemperature();

            // Wait for the user to press a key before closing the program
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(); 
        }
    }
}
