using System;
using System.Collections.Generic;
using System.IO;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        SetAge(age);
    }

    public void Introduce()
    {
        Console.WriteLine("Hello, my name is " + Name);
    }

    public void SetAge(int newAge)
    {
        if (newAge >= 0)
        {
            Age = newAge;
        }
        else
        {
            Console.WriteLine("Age cannot be negative.");
        }
    }
}

public class Employee : Person
{
    public string Position { get; set; }

    public Employee(string name, int age, string position) : base(name, age)
    {
        Position = position;
    }
}

public class PersonFileService
{
    
}

public class Program
{
    public static void Main()
    {
        // Список людей для чтения и записи в файл
        var people = new List<Person>
        {
            new Person("Alice", 28),
            new Person("Bob", 35),
            new Employee("Charlie", 42, "Manager")
        };

        // Запись Person в файл
        //PersonFileService.WritePeopleToFile(people);

        // Чтение Person из файла
        //var peopleFromFile = PersonFileService.ReadPeopleFromFile();
        
        foreach (var person in peopleFromFile)
        {
            person.Introduce();
        }
    }
}

// Структура текущей программы
// +---------------------------------+
// |            Person               |
// +---------------------------------+
// | - name: string                  |
// | - age: int                      |
// +---------------------------------+
// | + Person(name: string, age: int)|
// | + Introduce(): void             |
// | - SetAge(newAge: int): void     |
// +---------------------------------+
//                  ▲
//                  |
// +---------------------------------+
// |            Employee             |
// +---------------------------------+
// | - position: string              |
// +---------------------------------+
// | + Employee(name: string,        |
// |            age: int,            |
// |            position: string)    |
// +---------------------------------+
// Для практики B и C необходимо добавить PersonFileService
//
//
// +---------------------------------+
// |        PersonFileService        |
// +---------------------------------+
// | + ReadPeopleFromFile(): Person[]|
// | + WritePeopleToFile(people: Person[]): void|
// +---------------------------------+