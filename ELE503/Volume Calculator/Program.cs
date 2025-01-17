using System;

namespace VolumeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Volume Calculator");

            // Input length
            Console.Write("Enter the length (in meters): ");
            double length = Convert.ToDouble(Console.ReadLine());

            // Input width
            Console.Write("Enter the width (in meters): ");
            double width = Convert.ToDouble(Console.ReadLine());

            // Input height
            Console.Write("Enter the height (in meters): ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Calculate volume
            double volume = CalculateVolume(length, width, height);

            // Output result
            Console.WriteLine("The volume is: " + volume + " cubic meters.");
        }

        // Method to calculate volume
        static double CalculateVolume(double l, double w, double h)
        {
            // TODO: Implement volume calculation
            return 0.0;
        }
    }
}
