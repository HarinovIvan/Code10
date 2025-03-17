using System;
using System.IO;

class Program
{
    static void Main()
    {
        const string path = "example.txt";
        string content = "Привет, мир!";

        File.WriteAllText(path, content);

        if (File.Exists("example.txt")){
            Console.WriteLine("Файл существует!");
            
            string text = File.ReadAllText(path);
            Console.WriteLine(text);

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}