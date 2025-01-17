

// Step 1: Setting Up Serial Communication

using System;
using System.IO.Ports;
using System.Net.NetworkInformation;

public class HardwareInterface
{
    private  SerialPort serialPort;

    public HardwareInterface(string portName, int baudRate)
    {
        serialPort = new SerialPort(portName, baudRate);
        serialPort.DataReceived += SerialPort_DataReceived;
    }

    public void OpenConnection()
    {
        if (!serialPort.IsOpen)
            serialPort.Open();
    }

    public void CloseConnection()
    {
        if (serialPort.IsOpen)
            serialPort.Close();
    }

    private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
        string data = serialPort.ReadLine();
        Console.WriteLine($"Data Received: {data}");
    }
}

// Step 2: Using the HardwareInterface Class

public class Program
{
    public static void Main(string[] args)
    {
        HardwareInterface hw = new HardwareInterface("COM3", 9600);
        hw.OpenConnection();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

        hw.CloseConnection();
    }
}
