using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter");

            // Input temperature in Celsius
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            // Convert to Fahrenheit
            double fahrenheit = ConvertToFahrenheit(celsius);

            // Output result
            Console.WriteLine(celsius + "°C is equal to " + fahrenheit + "°F.");
        }

        // Method to convert Celsius to Fahrenheit
        static double ConvertToFahrenheit(double c)
        {
            // TODO: Implement conversion
            return 0.0;
        }
    }
}
