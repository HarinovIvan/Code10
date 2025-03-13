using System;

class Person
{
    public string name;
    public int age;
    private string Name_users;
    private int Age_users;

    public void Introduce();
    {
        Console.WriteLine($"Мое имя {name}");
    }
    
    public Person(string name_users, int age_users)
    {
        Name_users = name_users;
        Age_users = age_users;
        nam.name = name;
        nam.age = age;
    }



}

class Program
{
    static void Main()
    {
        Person person = new Person[];
        person.name = "Ivan";
        person.age = 16;

        Console.WriteLine(person.name);
        Console.WriteLine(person.age);

        int[] person = new Person[];
        person[0].name = "1";
        person[1].name = "2";
        person[2].name = "3";
        foreach(int num in person)
        {
            Console.WriteLine(num);
        }
    }
}

