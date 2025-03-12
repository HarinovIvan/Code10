namespace CSProject;
using System;

class CSProject
{
    //практика a
    //1
    // static int add(int a, int b)
    // {
    //     return a + b;
    // }

    //2

    // static bool is_even(int number)
    // {
    //     return number % 2 == 0;
    // }

    //3

    // static string reverse_string(string s){
    //     char[] charArray = s.ToCharArray();
    //     string reversed = new string(Array.Reverse(charArray));
    //     return reversed;
    // }

    //4


    // static int[] find_max(arr)
    // {
    //     return array.Max(arr);
    // }

    //5

    // static int factorial(sallary)
    // {
    //     return sallary * 12;
    // }

    //практика b

    //6

    // static int celsius_to_fahrenheit(celsius)
    // {
    //     return celsius * 9/5 + 32;
    // }

    //7

    // static string count_vowels(string s)
    // {
    //     vowels = "аиоуеэАИОУЕЭ"
    //     foreach (char c in s){
    //         return vowels.Contains(c);
    //     }
    // }

    //8

    // static int generate_password(passtohack)
    // {
    //     int count = 0;
    //     for(int x = 0; x < 10; x++){
    //         for(int y = 0; y < 10; y++){
    //             for(int z = 0; z < 10; z++){
    //                 for(int h = 0; h < 10; h++){
    //                     count++
    //                     string generatedpass = Convert.ToString(x) + Convert.ToString(y) + Convert.ToString(z) + Convert.ToString(h);
    //                     if(generatedpass  == passtohack){
    //                         Console.WriteLine("Ура! Вы взломали пароль теперь вы хакер");
    //                         return count;
    //                     }:
    //                 }
    //             }
    //         }
    //     }
    // }

    //практика с

    //1

    // static int Factorial(int n)
    // {
    // if (n == 1) return 1; 
    // return n * Factorial(n - 1);
    // }

    //2

    // static int Fibonacci(int n)
    // {
    //     if (n <= 0)
    //     {
    //         return 0;
    //     }
    //     else if (n == 1)
    //     {
    //         return 1;
    //     }
    //     else
    //     {
    //         return Fibonacci(n - 1) + Fibonacci(n - 2);
    //     }
    // }

    //3

    // static string reverse_string_two(string s){
    //     char[] charArray = s.ToCharArray();
    //     string reversed = new string(Array.Reverse(charArray));
    //     return reversed;
    // }
    //4

    // static int SumArray(int[] arr, int index)
    // {
    //     if (index < 0)
    //     {
    //         return 0;
    //     }
    //     else
    //     {
    //         return arr[index] + SumArray(arr, index - 1);
    //     }
    // }

    //5

    // static int NOD(int a, int b)
    // {
    //     if (b == 0)
    //     {
    //         return a;
    //     }
    //     else
    //     {
    //         return a % b;
    //     }
    // }

    //6

    // static bool IsPalindrome(string str)
    // {
    //     if (str.Length <= 1)
    //     {
    //         return true;
    //     }
    //     if (str[0] != str[str.Length - 1])
    //     {
    //         return false;
    //     }
    //     return IsPalindrome(str.Substring(1, str.Length - 2));
    // }






    static void Main(String[] args)
    {
        // Console.WriteLine(add());
        // Console.WriteLine(is_even());
        // Console.WriteLine(reverse_string());
        // Console.WriteLine(find_max());
        // Console.WriteLine(factorial());
        // Console.WriteLine(celsius_to_fahrenheit());
        // Console.WriteLine(count_vowels());
        // Console.WriteLine(generate_password(passtohack));
        // Console.WriteLine(Factorial());
        // Console.WriteLine(Fibonacci());
        // Console.WriteLine((reverse_string_two));


        // int[] array = { 1, 2, 3, 4, 5 };
        // int sum = SumArray(array, array.Length - 1);
        // Console.WriteLine("Сумма элементов массива: " + sum);


        // Console.Write("Введите первое число:");
        // int a = Convert.ToInt32(Console.ReadLine());

        // Console.Write("Введите второе число:");
        // int b = Convert.ToInt32(Console.ReadLine());

        // int qwe = NOD(a, b);
        // Console.WriteLine($"{qwe}");

        // Console.Write("Введите строку:");
        // string inputString = Console.ReadLine();

        // if (IsPalindrome(inputString))
        // {
        //     Console.WriteLine("Строка является палиндромом.");
        // }
        // else
        // {
        //     Console.WriteLine("Строка не является палиндромом.");
        // }
    }
}