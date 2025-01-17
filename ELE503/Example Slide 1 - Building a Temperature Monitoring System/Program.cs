
// Step 1: Define the Sensor Class
public abstract class Sensor
{
    public string ID { get; set; }

    public Sensor(string id)
    {
        ID = id;
    }

    public abstract double ReadValue();
}


// Step 2: Implement a TemperatureSensor Class

public class TemperatureSensor : Sensor
{
    public TemperatureSensor(string id) : base(id) { }

    public override double ReadValue()
    {
        // Simulate reading temperature
        Random rand = new Random();
        return rand.NextDouble() * 100; // Returns a value between 0 and 100
    }
}

// Step 3: Create the Data Acquisition Module

public class DataAcquisition
{
    private List<Sensor> sensors;

    public DataAcquisition()
    {
        sensors = new List<Sensor>();
    }

    public void AddSensor(Sensor sensor)
    {
        sensors.Add(sensor);
    }

    public Dictionary<string, double> CollectData()
    {
        Dictionary<string, double> data = new Dictionary<string, double>();
        foreach (var sensor in sensors)
        {
            data[sensor.ID] = sensor.ReadValue();
        }
        return data;
    }
}

// Step 4: Develop the User Interface

public class Program
{
    public static void Main(string[] args)
    {
        DataAcquisition daq = new DataAcquisition();
        daq.AddSensor(new TemperatureSensor("TempSensor1"));
        daq.AddSensor(new TemperatureSensor("TempSensor2"));

        while (true)
        {
            var data = daq.CollectData();
            Console.Clear();
            Console.WriteLine("Temperature Monitoring System");
            Console.WriteLine("-----------------------------");
            foreach (var entry in data)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value:F2}°C");
            }
            System.Threading.Thread.Sleep(1000); // Wait for 1 second
        }
    }
}
