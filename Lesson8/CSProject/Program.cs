using System;
using System.Collections.Generic;
using System.IO;

using System;

abstract class Animal
{
    public string Name { get; set; } // Поле (свойство)
    
    public Animal(string name) // Конструктор
    {
        Name = name;
    }

    public void Sleep() // Обычный метод (с реализацией)
    {
        Console.WriteLine($"{Name} спит... 😴");
    }

    public abstract void MakeSound(); // Абстрактный метод (без реализации)
}

class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override void MakeSound() // Реализация метода
    {
        Console.WriteLine($"{Name} лает: Гав-гав! 🐶");
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} мяукает: Мяу-мяу! 🐱");
    }
}

class Program
{
    static void Main()
    {
        Animal myDog = new Dog("Шарик");
        Animal myCat = new Cat("Мурка");

        myDog.MakeSound(); // Шарик лает: Гав-гав! 🐶
        myCat.MakeSound(); // Мурка мяукает: Мяу-мяу! 🐱

        myDog.Sleep(); // Шарик спит... 😴
        myCat.Sleep(); // Мурка спит... 😴
    }
}