


public class BinomialDistribution
{
    private int n;
    private double p;
    private Random rand;

    //constroctor than runs when you first initiaite this class
    public BinomialDistribution(int trials, double probability)
    {
        n = trials;
        p = probability;
        rand = new Random();
    }

    public int Generate()
    {
        int successes = 0;
       c
        return successes;
    }
}

// Usage Example
class Program
{
    static void Main(string[] args)
    {
        BinomialDistribution binomial = new BinomialDistribution(10, 0.5);


        int binomialSample = binomial.Generate();
        Console.WriteLine($"Binomial Sample: {binomialSample}");
    }
}
