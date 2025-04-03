using System;
using System.Collections.Generic;
using System.IO;

using System;

class Animal
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

    public virtual void MakeSound()
    {
        System.Console.WriteLine($"{Name} издает звук!");
    } 
}

class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override void MakeSound() // Реализация метода
    {
        Console.WriteLine($"{Name} лает: Гав-гав! 🐶");
    }

    private void dogEat()
    {
        System.Console.WriteLine($"{Name} кушает!");
    }
    
    public void eating()
    {
        dogEat();
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
        // Animal myAnimal = new Animal("");
        Dog myDog = new Dog("Шарик");

        myDog.dogEat();

        // Animal myCat = new Cat("Мурка");

        // myDog.MakeSound(); // Шарик лает: Гав-гав! 🐶
        // myCat.MakeSound(); // Мурка мяукает: Мяу-мяу! 🐱

        // myDog.Sleep(); // Шарик спит... 😴
        // myCat.Sleep(); // Мурка спит... 😴
    }
}