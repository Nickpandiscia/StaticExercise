using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(100);
            Console.WriteLine($"Converting 100F to celsius gives us {celsius}C. ");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(100);
            Console.WriteLine($"Converting 100C to fahrenheit gives us {fahrenheit}F.");
            Console.ReadLine();
        }
    }
}
