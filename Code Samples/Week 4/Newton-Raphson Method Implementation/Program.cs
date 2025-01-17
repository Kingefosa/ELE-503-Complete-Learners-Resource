

using System;

public class NewtonRaphson
{
    private Func<double, double> f;
    private Func<double, double> df;
    private double tolerance;
    private int maxIterations;

    public NewtonRaphson(Func<double, double> f, Func<double, double> df, double tolerance = 1e-6, int maxIterations = 100)
    {
        this.f = f;
        this.df = df;
        this.tolerance = tolerance;
        this.maxIterations = maxIterations;
    }

    public double FindRoot(double initialGuess)
    {
        double x0 = initialGuess;
        for (int i = 0; i < maxIterations; i++)
        {
            double y = f(x0);
            double yPrime = df(x0);
            if (yPrime == 0)
                throw new Exception("Derivative is zero. No solution found.");

            double x1 = x0 - y / yPrime;

            Console.WriteLine($"Iteration {i + 1}: x = {x1}");

            if (Math.Abs(x1 - x0) < tolerance)
                return x1;

            x0 = x1;
        }
        throw new Exception("Maximum iterations reached. No solution found.");
    }
}

// Usage Example
class Program
{
    static void Main(string[] args)
    {
        // Define the function f(x) = x^3 - 6x^2 + 11x - 6
        Func<double, double> func = x => x * x * x - 6 * x * x + 11 * x - 6;
        // Define the derivative f'(x) = 3x^2 - 12x + 11
        Func<double, double> dfunc = x => 3 * x * x - 12 * x + 11;

        NewtonRaphson nr = new NewtonRaphson(func, dfunc);
        double root = nr.FindRoot(3.5);
        Console.WriteLine($"Root found: {root}");
    }
}
