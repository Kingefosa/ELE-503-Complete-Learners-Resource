using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace CylinderVolumeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cylinder Volume Calculator");

            // Input radius
            Console.Write("Enter the radius of the cylinder (in meters): ");
            double radius = Convert.ToDouble(Console.ReadLine());

            // Input height
            Console.Write("Enter the height of the cylinder (in meters): ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Calculate volume
            double volume = CalculateVolume(radius, height);

            // Output result
            Console.WriteLine("The volume of the cylinder is: " + volume + " cubic meters.");
        }

        // Method to calculate volume
        static double CalculateVolume(double r, double h)
        {
            double pi = 3.14159;
            return pi * r * r * h;
        }
    }
}


//Sample Output
//Cylinder Volume Calculator
//Enter the radius of the cylinder (in meters): 3
//Enter the height of the cylinder (in meters): 5
//The volume of the cylinder is: 141.37155 cubic meters.