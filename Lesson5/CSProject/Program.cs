using System;

class Car
{
    // Поля (свойства машины)
    public string Brand;
    public string Model;
    protected int Year;

    // Конструктор (вызывается при создании объекта)
    public Car(string brand, string model, int year)
    {
        if (year < 0) return;
        Brand = brand;
        Model = model;
        Year = year;
    }

    // Метод (функция)
    public void ShowInfo()
    {
        Console.WriteLine($"Авто: {Brand} {Model}, {Year} года");
    }

    public void SetYear(int year)
    {
        if (year < 0) return;
        Year = year;
    }
}


// Использование класса
class Program
{
    static void Main()
    {   

        Car myCar = new Car("Toyota", "Corolla", 2022); // Создаём объект
        myCar.ShowInfo(); // Выведет: "Авто: Toyota Corolla, 2022 года"
        myCar.Year = 0;

        // int[,] matrix = {
        //     { 1, 2, 3 },
        //     { 4, 5, 6 },
        //     { 7, 8, 9 }
        // };

        // int[,] matrix_2 = matrix;

        // matrix_2[2, 2] = 99;

        // for (int i = 0; i < matrix.GetLength(0); i++)
        // {
        //     for (int j = 0; j < matrix.GetLength(1); j++)
        //     {
        //         System.Console.Write(matrix[i, j] + " ");
        //     }
        //     System.Console.WriteLine();
        // }

        // foreach (int num in matrix)
        // {
        //     Console.WriteLine(num);
        // }

        // 1 2 3
        // 4 5 6
        // 7 8 9
    }
}
