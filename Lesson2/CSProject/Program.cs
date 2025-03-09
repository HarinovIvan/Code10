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
    // Console.WriteLine("Введите перовое число:");
    // int number_one = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Введите второе число:");
    // int number_two = Convert.ToInt32(Console.ReadLine());
    // int summ = number_one + number_two;
    // Console.WriteLine($"Сумма чисел: {summ}");
    
    // // 2
    // Random random = new Random();
    // int number_random = random.Next(0, 10);
    // Console.WriteLine("Введите число:");
    // int number_users = 0;
    // while(number_random != number_users){
    //     number_users = Convert.ToInt32(Console.ReadLine());
    //     if(number_users < number_random){
    //         Console.WriteLine("Ваше чисвло меньше загаданного");
    //     } else if(number_users > number_random){
    //         Console.WriteLine("Ваше число больше загаданного");
    //     } 
    //     else {
    //         Console.WriteLine("Ура вы отгдали число!!!!");
    //         break;
    //     }
    // }

    // //1
    
    // int[] numbers = {0, 1, 2, 3, 4, 5};
    // int result = 0;
    // foreach(int num in numbers){
    //     result += num;
    // }
    // Console.WriteLine(result);

    // //2
    // int[] numbers = {0, 1, 2, 3, 4, 5};
    // int result = int.MinValue;
    // foreach(num in numbers){
    //     if(result > num){
    //         result = num;
    //     }
    // }
    // Console.WriteLine(result);

    // //3
    
    // int[] numbers = {0, 1, 2, 3, 4, 5};
    // Array.Reverse(numbers);
    // foreach(num in numbers){
    //     Console.WriteLine(num);
    // }

    // // 4

    // int[] numbers = {0, 1, 2, 3, 4, 5};
    // foreach(num in numbers){
    //     if(num % 2 == 0){
    //         Console.WriteLine(num);
    //     }
    // }

    //5

    // int[] number = {0, 1, 2, 3, 4, 5 -1, -5, 54, -23};
    // int count = 0;
    // for (int i = 0; i < array.Length; i++){
    // if (array[i] < 0){
    //    count++;
    //    } 
    // }
    // Console.WriteLine(count);
    //    
    //         
    //     
    // 

    // 6

    // int[] number = {0, 1, 2, 3, 4, 5 -1, -5, 54, -23};
    // int target = 2;
    // foreach(int num in number){
    //     if (num == target){
    //         Console.WriteLine("Число найдено");
    //         return;
    //     }
    // }
    // Console.WriteLine("Число не найдено");

    //7

    // int[] number = {0, 1, 2, 3, 4, 5 -1, -5, 54, -23};
    // for(int i = 0; i < 9; i++){
    //     if(number[i] % 2 != 0){
    //         Console.WriteLine(number[i]);
    //     }
    // }

    //8
    // int[] number = {0, 1, 2, 3, 4, 5 -1, -5, 54, -23};
    // Console.WriteLine(number.Min());
    // Console.WriteLine(number.Max());

    // 9
    // int[] number = {0, 1, 2, 3, 4, 5 -1, -5, 54, -23};
    // Array.Sort(number);
    // foreach(int num in number){
    //     Console.WriteLine(num);
    // }

    //10

    // int[] number = {0, 1, 2, 3, 4, 5 -1, -5, 54, -23};
    // for(int i = 0; i < 10; i++){
    //     if(number[i] < 0){
    //         number[i] = 0;
    //     }
    // }
    // Console.WriteLine(number);

    //11



    //12
    // int[] numbers = {1, 2, 3, 3, 3, 3, 4, 5, 5, 5};
    // Array.Sort(numbers);
    // int distinct = numbers.Distinct().Count();
    // Console.WriteLine(distinct);

    //13

        // int[] numbers = { 1, 2, 3, 2, 3, 3, 4, 4, 4, 4 };
        // int[] count = new int[numbers.Length];
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     count[i] = 0;
        // }
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     for (int j = i; j < numbers.Length; j++)
        //     {
        //         if (numbers[i] == numbers[j])
        //         {
        //             count[i]++;
        //         }
        //     }
        // }
        // int maxCount = 0;
        // for (int i = 0; i < count.Length; i++)
        // {
        //     if (count[i] > maxCount)
        //     {
        //         maxCount = count[i];
        //     }
        // }
        // for (int i = 0; i < count.Length; i++)
        // {
        //     if (count[i] == maxCount)
        //     {
        //         Console.WriteLine($"Число {numbers[i]} встречается {maxCount} раз.");
        //     }
        // }


        //Домашнее задание

        //1Напишите программу, которая объединяет два массива целых чисел в один. Элементы второго массива должны следовать за элементами первого массива.
        
        int[] array_one = {1, 2, 3, 4, 5};
        int[] array_two = {6, 7, 8, 9, 10};
        int[] array_all = array_one.Concat(array_two).ToArray();
        foreach(int num in array_all){
            Console.WriteLine(num);
        }

        //2Создайте программу, которая осуществляет циклическую ротацию массива на заданное количество позиций вправо. Например, ротация массива [1, 2, 3, 4, 5] на две позиции даст [4, 5, 1, 2, 3].

        int[] originalArray = {1, 2, 3, 4, 5};
        int k = 2;
        if(k > originalArray.Length){
            k = k % originalArray.Length;
        }
        int[] newArray = new int[originalArray.Length];
        for (int i = 0; i < originalArray.Length; i++){
            newArray[(i + k) % originalArray.Length] = originalArray[i];
        }

        foreach(int num in newArray){
            Console.WriteLine(num);
        }
    }
}