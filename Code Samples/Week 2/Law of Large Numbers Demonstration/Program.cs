

public class LawOfLargeNumbersDemo
{
    private int sampleSize;
    private Random rand;

    public LawOfLargeNumbersDemo(int sampleSize)
    {
        this.sampleSize = sampleSize;
        rand = new Random();
    }

    public void RunDemo()
    {
        double sum = 0.0;
        for (int i = 1; i <= sampleSize; i++)
        {
            double sample = rand.NextDouble(); // Uniform distribution [0,1)
            sum += sample;
            double sampleMean = sum / i;
            Console.WriteLine($"Sample {i}: Mean = {sampleMean:F4}");
        }
    }
}

// Usage Example
class Program
{
    static void Main(string[] args)
    {
        LawOfLargeNumbersDemo llnd = new LawOfLargeNumbersDemo(1000);
        llnd.RunDemo();
    }
}
