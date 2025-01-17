using System;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Number Checker");

            // Input number
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if prime
            bool isPrime = IsPrime(number);

            // Output result
            if (isPrime)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else
            {
                Console.WriteLine(number + " is not a prime number.");
            }
        }

        // Method to check prime
        static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}
