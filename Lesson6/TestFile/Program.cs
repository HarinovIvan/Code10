using System;
using System.IO;

class Program
{
    static void addArrayToFile(string path, int[] array){
        var file = File.AppendText(path);
        foreach (int item in array)
        {
            file.Write($"{item} ");
        }
        file.Close();
    }

    static void Main()
    {
        const string path = "example.txt";

        // int[] array = { 50, 40, 30, 20 };

        // addArrayToFile(path, array);


        // string[] file = { "Еще одна строка", "abc" };

        // File.AppendAllLines(path, file);
        // File.WriteAllLines(path, file);


        // foreach (string item in file)
        // {
        //     System.Console.WriteLine(item);
        // }
        
        // file[0] = "Новый текст";

        string content = "Привет, мир!";

        File.WriteAllText(path, content);

        if (File.Exists(path)){
            Console.WriteLine("Файл существует!");
            
            string text = File.ReadAllText(path);
            Console.WriteLine(text);

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        // int[] newArray = { 1, 2, 3, 4, 5 };
        // addArrayToFile(path, newArray);
    }
}