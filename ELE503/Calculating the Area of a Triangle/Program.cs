using System;

namespace EngineeringCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle Area Calculator");

            Console.Write("Enter the base of the triangle (in meters): ");
            double baseLength = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the triangle (in meters): ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = CalculateArea(baseLength, height);

            Console.WriteLine("The area of the triangle is: " + area + " square meters.");
        }

        static double CalculateArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }
    }
}
