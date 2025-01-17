using System;

public class GaussSeidel
{
    private double[,] A;
    private double[] b;
    private double[] x;
    private double tolerance;
    private int maxIterations;

    public GaussSeidel(double[,] A, double[] b, double[] initialGuess, double tolerance = 1e-6, int maxIterations = 1000)
    {
        this.A = A;
        this.b = b;
        this.x = initialGuess;
        this.tolerance = tolerance;
        this.maxIterations = maxIterations;
    }

    public double[] Solve()
    {
        int n = b.Length;
        double[] xOld = new double[n];
        Array.Copy(x, xOld, n);

        for (int iter = 0; iter < maxIterations; iter++)
        {
            for (int i = 0; i < n; i++)
            {
                double sum = 0.0;
                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                        sum += A[i, j] * x[j];
                }
                x[i] = (b[i] - sum) / A[i, i];
            }

            // Check for convergence
            double error = 0.0;
            for (int i = 0; i < n; i++)
            {
                error += Math.Abs(x[i] - xOld[i]);
            }

            Console.WriteLine($"Iteration {iter + 1}: x = {x[0]}, y = {x[1]}");

            if (error < tolerance)
                return x;

            Array.Copy(x, xOld, n);
        }
        throw new Exception("Maximum iterations reached. Solution may not have converged.");
    }
}

// Usage Example
class Program
{
    static void Main(string[] args)
    {
        // System:
        // 3x + y = 9
        // x + 2y = 8

        double[,] A = new double[,]
        {
            {3, 1},
            {1, 2}
        };

        double[] b = new double[] { 9, 8 };
        double[] initialGuess = new double[] { 0, 0 };

        GaussSeidel gs = new GaussSeidel(A, b, initialGuess);
        double[] solution = gs.Solve();

        Console.WriteLine($"Solution: x = {solution[0]}, y = {solution[1]}");
    }
}
