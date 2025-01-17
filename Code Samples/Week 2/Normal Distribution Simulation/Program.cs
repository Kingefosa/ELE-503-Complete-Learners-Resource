using System;

public class NormalDistribution
{
    private double mean;
    private double stdDev;
    private Random rand;

    public NormalDistribution(double mean, double stdDev)
    {
        this.mean = mean;
        this.stdDev = stdDev;
        this.rand = new Random();
    }

    public double Generate()
    {
        // Box-Muller transform
        double u1 = 1.0 - rand.NextDouble(); // Avoid zero
        double u2 = 1.0 - rand.NextDouble();
        double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                               Math.Sin(2.0 * Math.PI * u2);
        return mean + stdDev * randStdNormal;
    }
}

// Usage Example
class Program
{
    static void Main(string[] args)
    {
        int length = 100;
        for (int i = 0; i < length; i++)
        {
        NormalDistribution normal = new NormalDistribution(0, 1);
        double sample = normal.Generate();
        Console.WriteLine($"Normal Sample: {sample}");
        }
        
    }
}
