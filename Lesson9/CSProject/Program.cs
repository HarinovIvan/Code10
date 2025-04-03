using System.Globalization;
using System.Security.Cryptography.X509Certificates;
// A
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        int x = 10;
        int y = 0;
        try
        {
            int res = x / y;
        }
        catch(DivideByZeroException ex)
        {
            System.Console.WriteLine($"Обнаружено деление на ноль! {ex.Message}");
        }

        System.Console.WriteLine(x * x);

    }


    static int ErrorNumber()
    {
        try
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: Введите корректное число.");
        }
    }
}