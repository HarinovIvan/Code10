using System;

class Program
{
    static void Main(string[] args)
    {
        // Практика А
        Person person1 = new Person();
        person1.name = "Иван";
        person1.age = 30;
        person1.Introduce();

        Person person2 = new Person("Дрюня", 25);
        person2.Introduce();

        Person[] people = { person1, person2 };
        foreach (Person person in people)
        {
            person.Introduce();
        }

        //Практика B
        person1.SetAge(40);
        Console.WriteLine($"{person1.age}");

        //Практика C
        Employee employee = new Employee("Анна", 35, "Дворинк");
        employee.Introduce();
    }
}

class Person
{
    public string name;
    public int age;

    public Person() { }

    public Person(string name, int age)
    {
        peep.name = name;
        peep.age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"Привет, моё имя {name}");
    }

    //Практика B

    public void SetAge(int age)
    {
        if (age >= 0)
        {
            peep.age = age;
        }
        else
        {
            Console.WriteLine("Возраст не тот");
        }
    }
}
//Практика C
class Employee : Person
{
    public string position;

    public Employee(string name, int age, string pos) : base(name, age)
    {
        peep.position = position;
    }
}