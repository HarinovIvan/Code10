namespace CSProject;
using System;

class CSProject
{
    static void Main(String[] args)
    {
        // string shoppingListItem_1 = "Хлеб";
        // string shoppingListItem_2 = "";
        
        // string[] shoppingList = { "bread", "milk", "cola" };
        
        // System.Console.WriteLine(shoppingList.Length);

        // for (int i = 0; i < 5; i++)
        // {
        //     System.Console.WriteLine(i);
        // }

    //    //A1.
    //     int[] array = new int[5];

    //     //A2.
    //     string[] array_str = { "1", "2", "3",};

    //     //B3.
    //     int[] array_int = { 1, 2, 3, 4, 5 };
    //     Console.WriteLine(array_int[1]);
    //     array_int[2] = 100;
    //     Console.WriteLine(array_int[2]);

    //     //B4.
    //     Console.WriteLine(array_int.Length);

    //     //C5.
    //     float[] array_float = new float[4];
    //     Console.WriteLine(array_float[3]);

    //     //C6
    //     int[] array_one = new int[5];
    //     Console.WriteLine(array_one);
    //     //C7
    //     char[] array_int_one = { 'a', 'b', 'c'};
    //     Console.WriteLine(array_int_one);
    //     //C8
    //     int[] array_hand = new int[5];
    //     int array_hand[0] = 1;
    //     int array_hand[1] = 2;
    //     int array_hand[2] = 3;
    //     int array_hand[3] = 4;
    //     int array_hand[4] = 5;
    //     Console.WriteLine(array_hand);

    //Домашнее задание
    // 1
    Console.WriteLine("Введите перовое число:");
    int number_one = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int number_two = Convert.ToInt32(Console.ReadLine());
    int summ = number_one + number_two;
    Console.WriteLine($"Сумма чисел: {summ}");
    
    // 2
    Random random = new Random();
    int number_random = random.Next(0, 10);
    Console.WriteLine("Введите число:");
    int number_users = 0;
    while(number_random != number_users){
        number_users = Convert.ToInt32(Console.ReadLine());
        if(number_users < number_random){
            Console.WriteLine("Ваше чисвло меньше загаданного");
        } else if(number_users > number_random){
            Console.WriteLine("Ваше число больше загаданного");
        } 
        else {
            Console.WriteLine("Ура вы отгдали число!!!!");
            break;
        }
    }
    }
}