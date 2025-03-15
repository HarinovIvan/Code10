using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Практика А
//         Person person1 = new Person();
//         person1.name = "Иван";
//         person1.age = 30;
//         person1.Introduce();

//         Person person2 = new Person("Дрюня", 25);
//         person2.Introduce();

//         Person[] people = { person1, person2 };
//         foreach (Person person in people)
//         {
//             person.Introduce();
//         }

//         //Практика B
//         person1.SetAge(40);
//         Console.WriteLine($"{person1.age}");

//         //Практика C
//         Employee employee = new Employee("Анна", 35, "Дворинк");
//         employee.Introduce();
//     }
// }

// class Person
// {
//     public string name;
//     public int age;

//     public Person() { }

//     public Person(string name, int age)
//     {
//         this.name = name;
//         this.age = age;
//     }

//     public void Introduce()
//     {
//         Console.WriteLine($"Привет, моё имя {name}");
//     }

//     //Практика B

//     public void SetAge(int age)
//     {
//         if (age >= 0)
//         {
//             this.age = age;
//         }
//         else
//         {
//             Console.WriteLine("Возраст не тот");
//         }
//     }
// }
// //Практика C
// class Employee : Person
// {
//     public string position;

//     public Employee(string name, int age, string pos) : base(name, age)
//     {
//         this.position = position;
//     }
// }

//домашнее задание
//1
class Homework
{
    static void Main()
    {
        // int[] array = { 1, 2, 5, 2, 5, 5, 4 };
        // int num1 = num_one(array);
        // Console.WriteLine($"Элемент, который встречается чаще всего: {num1}");

        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] transposedMatrix = Old_Matrix(matrix);

        Console.WriteLine("Исходная матрица:");
        New_Matrix(matrix);

        Console.WriteLine("Транспонированная матрица:");
        New_Matrix(transposedMatrix);
    }

    // static int num_one(int[] array)
    // {
    //     int maxCount = 0;
    //     int num3 = 0;

    //     for (int i = 0; i < array.Length; i++)
    //     {
    //         int count = 0;
    //         for (int j = 0; j < array.Length; j++)
    //         {
    //             if (array[i] == array[j])
    //             {
    //                 count++;
    //             }
    //         }

    //         if (count > maxCount)
    //         {
    //             maxCount = count;
    //             num3 = array[i];
    //         }
    //     }

    //     return num3;
    // }

    // 2
    static int[,] Old_Matrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] transposedMatrix = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposedMatrix[j, i] = matrix[i, j];
            }
        }

        return transposedMatrix;
    }

    static void New_Matrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    
}