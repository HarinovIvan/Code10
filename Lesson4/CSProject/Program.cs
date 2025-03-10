namespace CSProject;
using System;

class CSProject
{
    static double Multiply(double x, double y)
    {   
        return x * y;
    }

    static void Main(String[] args)
    {
        double result = Multiply(4.3, 2);
        Console.WriteLine(result);
    }
}