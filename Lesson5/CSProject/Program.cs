using System;

class Car
{
    // Поля (свойства машины)
    public string Brand;
    public string Model;
    public int Year;

    // Конструктор (вызывается при создании объекта)
    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    // Метод (функция)
    public void ShowInfo()
    {
        Console.WriteLine($"Авто: {Brand} {Model}, {Year} года");
    }
}

// Использование класса
class Program
{
    static void Main()
    {
        Car myCar = new Car("Toyota", "Corolla", 2022); // Создаём объект
        myCar.ShowInfo(); // Выведет: "Авто: Toyota Corolla, 2022 года"
    }
}
