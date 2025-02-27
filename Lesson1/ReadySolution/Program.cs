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

        //Практика Б
        //Попросите пользователя ввести свое имя, а затем выведите приветствие с использованием переменной для имени.
        Console.WriteLine("Введите своё имя");
        string name1 = Console.ReadLine();
        Console.WriteLine($"Hello, {name1}");

        //Попросите пользователя ввести свой год рождения, а затем используйте переменную для вычисления и вывода его возраста.
        Console.WriteLine("Введите свой год рождения");
        int year = Convert.ToInt32(Console.ReadLine());
        int year_new = 2025;
        int year_old = year_new - year;
        Console.WriteLine($"Age: {year_old}");

        //Создайте программу, которая позволяет пользователю вводить и сохранять имена и телефонные номера в переменных, а затем выводить их на экран.
        Console.WriteLine("Введите своё имя");
        string you_name = Console.ReadLine();
        Console.WriteLine("Введите свой номер телефона");
        int phone = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($" You name: {you_name} You phone: {phone}");

        //Практика с
        //Попросите пользователя ввести два числа. Выведите сначала большее, потом меньшее
        Console.WriteLine("Введите первое число");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if(num > num2){
            Console.WriteLine(num);
            Console.WriteLine(num2);
        } else if(num < num2){
            Console.WriteLine(num2);
            Console.WriteLine(num);
        }
        else{
            Console.WriteLine("Числа равны");
        }

        //Попросите пользователя ввести число. Выведите разряды числа, а именно: количество сотен, десятков и единиц.
        Console.WriteLine("Введите число");
        int numb = Convert.ToInt32(Console.ReadLine());
        int hund = numb / 100;
        int des = (numb / 10) %  10;
        int ed = numb % 10;
        Console.WriteLine($"Сотни: {hund} десятки: {des} еденицы: {ed}");

    }
}
