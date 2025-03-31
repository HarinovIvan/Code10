using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

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
    public Person[] ReadPeopleFromFile()
    {
        const string fileName = "persons.txt";
        string[] persons = File.ReadAllLines(fileName);

        var people = new List<Person>();
        // Person[] test = new Person[persons.Length / 2];
        for (int i = 0; i < persons.Length; i += 2){
            people.Add(new Person(persons[i], Convert.ToInt32(persons[i+1])));
        }

        Person[] array = people.ToArray();

        return array;
    }

    public void WritePeopleToFile(Person[] people)
    {

    }

}

public class Program
{
    static void readAndWrite()
    {
        const string fileName = "Test.txt";

        File.WriteAllText(fileName, "TEST");

        string text = File.ReadAllText(fileName);
    }
    public static void Main()
    {

        // PersonFileService PFS = new PersonFileService();

        // Person[] array = PFS.ReadPeopleFromFile();

        // foreach(Person person in array)
        // {
        //     person.Introduce();
        // }

        // readAndWrite();

        // Список людей для чтения и записи в файл
        // Person[] peoples = {
        //     new Person("Alice", 28),
        //     new Person("Bob", 35),
        //     new Employee("Charlie", 42, "Manager")
        // };

        // var people = new List<Person>
        // {
        //     new Person("Alice", 28),
        //     new Person("Bob", 35),
        //     new Employee("Charlie", 42, "Manager")
        // };


        // int[] array = new int[5];

        // List<int> dynamic_array = new List<int>();
        // for (int i = 0; i < 5; i++){
        //     dynamic_array.Add(0);
        // }

        // System.Console.WriteLine("Массив:");
        // foreach (int i in array)
        // {
        //     Console.Write($"{i} ");
        // }

        // dynamic_array.Add(4);

        // System.Console.WriteLine("\r\nСписок:");
        // foreach (int i in dynamic_array)
        // {
        //     System.Console.Write($"{i} ");
        // }

        // System.Console.WriteLine($"\r\n {dynamic_array.Count}");
        // if (dynamic_array.Contains(4))
        // {
        //     System.Console.WriteLine("6 есть в списке");
        // }
        // else
        // {
        //     System.Console.WriteLine("6 нет в списке");
        // }

        Dictionary<string, int> Students = new Dictionary<string, int>();

        Students["Ivan"] = 40;
        Students["Abram"] = 30;

        Students.Remove("fjkdsjf");

        // int value;

        // if (Students.TryGetValue("Ivan", out value))
        // {
        //     System.Console.WriteLine(value);
        // }
        // else
        // {
        //     System.Console.WriteLine("Значение не найдено");
        // }

        // System.Console.WriteLine(value);

        // if (Students.ContainsValue(40)){
        //     System.Console.WriteLine("Значение есть!");
        // }
        // else
        // {
        //     System.Console.WriteLine("Значение не найдено!");
        // }

        // System.Console.WriteLine(Students["Ivan"]);

        // Person peep = new Person("Ivan", 40);

        // people[0] = peep;
        // people.Add(peep);
        // people[5] = peep;

        // peep.Introduce();

        // Запись Person в файл
        //PersonFileService.WritePeopleToFile(people);

        // Чтение Person из файла
        //var peopleFromFile = PersonFileService.ReadPeopleFromFile();
        
        // foreach (var person in peopleFromFile)
        // {
        //     person.Introduce();
        // }
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
// | + SetAge(newAge: int): void     |
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