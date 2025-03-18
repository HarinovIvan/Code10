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
//практика B
// public class PersonFileService
// {
//     public Person[] ReadPeopleFromFile()
//     {
//         const string fileName = "persons.txt";
//         string[] persons = File.ReadAllLines(fileName);
//         var people = new List<Person>();
//         for(int i = 0; i < persons.Length; i += 2)
//         {
//             people.Add(new Person(persons[i], Convert.ToInt32(persons[i+1])));
//         }
//         Person[] array = people.ToArray();
//         return array;
//     }

//     public void WritePeopleToFile(people Person[])
//     {
            string path = "persons.txt";  
            string name = "ivan";
            int Age = 20;      
            for (int i = 0; i , Person.Length; i++)
            {
                File.AppendAllText(path, $"{Person.name}\r\n{Person.Age}\r\n"
            }
//     }
// }

public class Program
{
    //Практика A
    // static void ReadandWrite()
    // {
    //     const string fileName = "Test.txt";
    //     File.WriteAllText(fileName, "test");
    //     string text = File.ReadAllText(fileName);
    // }

    public static void Main()
    {
        // ReadandWrite();

        //b
        // PersonFileService qwe = new PersonFileService();
        // Person[] array = qwe.ReadPeopleFromFile();
        // foreach(Person person in array)
        // {
        //     person.Introduce();
        // }

        PersonFileService qwe1 = new PersonFileService();
        Person[] array1 = qwe1.WritePeopleToFile();

        

        // Список людей для чтения и записи в файл
        // var people = new List<Person>
        // {
        //     new Person("Alice", 28),
        //     new Person("Bob", 35),
        //     new Employee("Charlie", 42, "Manager")
        // };

        // // Запись Person в файл
        // //PersonFileService.WritePeopleToFile(people);

        // // Чтение Person из файла
        // //var peopleFromFile = PersonFileService.ReadPeopleFromFile();
        
        // foreach (var person in peopleFromFile)
        // {
        //     person.Introduce();
        // }



        //практика c
        static void ReadmeMD(string[] path)
        {
            string path = "readme.MD";
            string con1 = "# Заголовок превого уровня";
            string con2 = "## Заголовок второго уровня";
            string con3 = "Текст в формате Markdown.";
            string con4 = "- Пункт списка";
            string con5  = "* пример маркированного текста";
            string con6  = "### Заголовок третьего уровня";
            string con7  = "**Жирный текст** и *курсив*";
            string con8  = "![Альтернативный текст](путь_к_изображению)";
            string con9  = "[Текст ссылки](https://....)";
            File.WriteAllText(path, con1, con2, con3, con4, con5, con6, con7, con8, con9);
            path.Save("Readme.md", SaveFormat.Markdown);
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