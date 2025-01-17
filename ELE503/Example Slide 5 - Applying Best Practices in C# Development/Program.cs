// Single Responsibility Principle
public class Logger
{
    public void Log(string message)
    {
        // Implement logging logic

        Console.WriteLine(message);
    }
}

public class MotorController
{
    private Logger logger;

    public MotorController(Logger logger)
    {
        this.logger = logger;
    }

    public void Start()
    {
        // Start motor logic
        logger.Log("Motor started.");
    }

    public void Stop()
    {
        // Stop motor logic
        logger.Log("Motor stopped.");

    }

    //public void Overheating()
    //{
    //    // Stop motor logic
    //    logger.Log("Motor Overheating.");
    //}
}


// code to demonstrate this
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Single Responsibility Principle demonstration");



        Logger log = new Logger() ;
        MotorController motorController = new MotorController(log) ;
        motorController.Start();
        motorController.Stop();

        //motorController.Overheating();

    }
}