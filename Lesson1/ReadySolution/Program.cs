namespace ReadySolution;

class Program
{
    static void Main(string[] args)
    {
        //практика А
        //Создайте программу на псевдоязыке, которая объявляет различные переменные разных типов данных (целочисленный, вещественный, строковый и логический) и выводит их значения на экран.
        int age = 16;
        Console.WriteLine($"Age: {age}");
        double age_2 = 16.5;
        Console.WriteLine($"Age_2: {age_2}");
        string name = "Ivan";
        Console.WriteLine($"Name: {name}");
        bool name_1 = true;
        Console.WriteLine($"Name_1: {name_1}");
        
        //Напишите программу, которая принимает два числа от пользователя и выполняет арифметические операции (сложение, вычитание, умножение, деление) над ними, выводя результат каждой операции на экран.
        Console.WriteLine("Введите первое число");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int number2 = Convert.ToInt32(Console.ReadLine());
        int sum = number1 + number2;
        Console.WriteLine($"Sum: {sum}");
        int total = number1 * number2;
        Console.WriteLine($"Total: {total}");
        int div = number1 - number2;
        Console.WriteLine($"Div: {div}");
        int del = number1 / number2;
        Console.WriteLine($"Del: {del}");
        //Напишите программу, которая принимает строку от пользователя, содержащую число, и конвертирует его в целое число. Затем увеличьте это число на 5 и выведите результат.
        Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        int total1 = number + 5;
        Console.WriteLine($"Total: {total1}");


        



    }
}
