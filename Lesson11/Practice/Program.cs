using System.Reflection;
using System.Runtime.InteropServices;

public delegate double MathOperation(double x, double y);

class Program
{
    // public static double Add(double x, double y)
    // {
    //     return x + y;
    // }

    // public static double Multiply(double x, double y)
    // {
    //     return x * y;
    // }

    // public static double ExecuteOperation(MathOperation operation, double x, double y)
    // {
    //     return operation(x, y);
    // }

    public static void Main()
    {
        // MathOperation handler = Multiply;
        // double i = ExecuteOperation(handler, 5, 5);
        // Console.WriteLine(i);
        // handler = Add;
        // i = ExecuteOperation(handler, 5, 5);
        // Console.WriteLine(i);

        TemperatureSensor sensor = new TemperatureSensor();
        
        sensor.TemperatureChanged += (send, temp) => 
        {
            System.Console.WriteLine($"Температура: {temp} C");
        };
        
        sensor.UpdateTemperature(50);
        sensor.UpdateTemperature(30);
        sensor.UpdateTemperature(84);
        sensor.UpdateTemperature(14);
        sensor.UpdateTemperature(43);
    }
}



class TemperatureSensor
{
    private double _Temperature;
    public double Temperature => _Temperature; 
    public event EventHandler<double> TemperatureChanged;

    public void UpdateTemperature(double newTemperature)
    {
        if (newTemperature != _Temperature)
        {
            _Temperature = newTemperature;

            TemperatureChanged?.Invoke(this, _Temperature);
        }
    }
}

