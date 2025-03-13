namespace CSProject;
using System;
using System.Dynamic;
using System.IO.Pipelines;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

class CSProject
{
    static void printArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write($"{array[i]}");
            if (i != array.Length - 1)
            {
                System.Console.Write(", ");
            }
        }
    }
    static void references()
    {
        int integer = 10; // оригинальная переменная
        int copyInteger = integer; // передается значение

        copyInteger++; // добавляем +1 к integer

        System.Console.WriteLine($"integer: {integer},\ncopyInteger: {copyInteger}\n");

        int[] array = { 10, 20, 30, 40, 50 }; // оригинальный массив
        int[] refArray = array; // передается ссылка на оригинальный массив

        for (int i = 0; i < refArray.Length; i++)
        {
            refArray[i]++; // добавляем +1 к каждому элементу массива
        }

        System.Console.Write("Оригинальный массив (array): ");
        printArray(array); // выводим оригинальный массив
        System.Console.Write("\nСсылка на массив (refArray): ");
        printArray(refArray); // выводим второй массив 

        string str = "ABC";
        string refStr = str;

        refStr = "AAA";
        System.Console.WriteLine($"\n{str}, {refStr}");
    }

    static bool Multiply(double x, double y, out double result) // Простой пример функции
    {   
        result = x * y;
        return true;
    }

    static int add(int a, int b)
    {
        return a + b;
    }

    static bool is_even(int number)
    {
        // if (number % 2 == 0)
        // {
        //     return true;
        // }
        // else
        // {
        //     return false;
        // }
        return number % 2 == 0;
    }
    
    static void Main(String[] args)
    {
        // double result;

        // if (Multiply(5, 5, out result) == true) {
        //     Console.WriteLine(result);
        // }
        // else {
        //     Console.WriteLine("Error");
        // }

        System.Console.WriteLine(add(2, 3));
        System.Console.WriteLine(is_even(5));
    }
}