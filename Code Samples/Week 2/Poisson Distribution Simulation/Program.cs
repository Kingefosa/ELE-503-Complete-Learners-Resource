


public class PoissonDistribution
{
    private double lambda;
    private Random rand;

    public PoissonDistribution(double lambda)
    {
        this.lambda = lambda;
        rand = new Random();
    }

    public int Generate()
    {
        double L = Math.Exp(-lambda);
        int k = 0;
        double p = 1.0;
        do
        {
            k++;
            p *= rand.NextDouble();
        }
        while (p > L);
        return k - 1;
    }
}

// Usage Example
class Program
{
    static void Main(string[] args)
    {
        PoissonDistribution poisson = new PoissonDistribution(4.0);

        int n = 10;
        for (int i = 0; i < n; i++)
        {
         int poissonSample = poisson.Generate();
        Console.WriteLine($"Poisson Sample: {poissonSample}");
        }
       
    }
}
