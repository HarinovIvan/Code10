using System.Globalization;
using System.Security.Cryptography.X509Certificates;
<<<<<<< HEAD
// A
=======

>>>>>>> upstream/main
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
<<<<<<< HEAD
=======
        // System.Console.WriteLine("Введите любое число");
        // int num = 0;
        // try
        // {
        //     num = Convert.ToInt32(Console.ReadLine());
        // }
        // catch (Exception ex)
        // {
        //     System.Console.WriteLine($"Произошла ошибка! {ex.Message}");
        // }

        // if (num < 0)
        // {
        //     throw new Exception("Число не может быть меньше нуля");
        // }

        // int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // foreach (int i in array)
        // {
        //     if (i % 2 == 0)
        //     {
        //         System.Console.Write($"{i} ");
        //     }
        // }

        // // var evenArray = array.Where(n => n % 2 == 0);

        // var evenArray = from n in array
        //                 where n % 2 == 0
        //                 orderby n descending
        //                 select n * 2;

        // System.Console.WriteLine();

        // foreach (int i in evenArray)
        // {
        //     System.Console.Write($"{i} ");
        // }

        // var people = new List<Person>
        // {
        //     new Person { Name = "Аня", Age = 25 },
        //     new Person { Name = "Борис", Age = 30 },
        //     new Person { Name = "Вика", Age = 25 },
        // };

        // var grouped = people.GroupBy(x => x.Age);

        // foreach (var group in grouped)
        // {
        //     System.Console.WriteLine($"Возраст: {group.Key}");

        //     foreach (var person in group)
        //     {
        //         System.Console.WriteLine($" - {person.Name}");
        //     }
        // }
>>>>>>> upstream/main
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
<<<<<<< HEAD


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
=======
>>>>>>> upstream/main
}