using System;
class Program
 
 public delegate int StringComparison(string str1, string str2);
 
     public static int CompareByLength(string str1, string str2)
     {
         return str1.CompareTo(str2);
     }
 
     public static int CompareByAlphabetical(string str1, string str2)
     {
         int score = 0;
         int len;
 
         if (str1.Length > str2.Length){
             len = str2.Length;
         }
         else
         {
             len = str1.Length;
         }
 
         for (int i = 0; i < len; i++)
         {
             if (str1[i] > str2[i])
             {
                 score++;
             }
             else
             {
                 score--;
             }
         }
         return score;
     }
 
     public static string[] SortStrings(StringComparison comparison, string[] strings)
     {
         for (int i = 0; i < strings.Length - 1; i++)
         {
             for (int j = 0; j < strings.Length - i - 1; j++)
             {
                 if (comparison(strings[i], strings[j]) > comparison(strings[j], strings[i]))
                 {
                     string temp = strings[i];
                     strings[i] = strings[j];
                     strings[j] = temp;
                 }
             }
         }
         return strings;
     }
 
     public static void Swap<T>(ref T x, ref T y)
     {
         T temp = x;
         x = y;
         y = temp;
     }
 
     public static void Finished()
     {
         System.Console.WriteLine("Завершение процесса успешно обработано");
     }
 
     public static void Main()
     {
         // practice A
         StringComparison del = CompareByLength;
         string[] test = [ "abc", "bca", "asdsad", "asfdsdf", "sg", "fsdjkfsdf" ];
         foreach (string testString in SortStrings(del, test))
         {
             Console.WriteLine(testString);
         }
 
         del = CompareByAlphabetical;
         foreach (string testString in SortStrings(del, test))
         {
             Console.WriteLine(testString);
         }


         //b

            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            string[] strings = { "sad", "sadfgd", "fewfdsf", "fsdf" };

            Console.WriteLine("Фильтрация четных чисел:");
            int[] evenNumbers = FilterCollection(numbers, IsEven);
            PrintArray(evenNumbers);

            Console.WriteLine("\nФильтрация длинных строк:");
            string[] longStrings = FilterCollection(strings, IsLongString);
            PrintArray(longStrings);


        //c
         BankAccount account = new BankAccount();
         account.BalanceChanged += Account_BalanceChanged;
         account.Deposit(100m);
         account.Withdraw(50m);
 
 
         // Box<string> box = new Box<string> { value = "djflksjfskdl" };
         // box.Print();
 
         // double a = 15.5;
         // double b = 30.49;
         // Swap(ref a, ref b);
 
         // System.Console.WriteLine(b);
 
         // Process process = new Process();
 
         // process.OnCompleted += Finished;
         // process.OnCompleted += Finished;
 
         // process.Start();
     }

     static void Account_BalanceChanged(object sender, BalanceChangedEventArgs e)
        {
            Console.WriteLine($"Старый баланс: {e.OldBalance}, новый баланс: {e.NewBalance}");
        }
 
 
 public delegate void Notify();
 
 class Process
 {
     public Notify OnCompleted;
 
     public void Start()
     {
         System.Console.WriteLine("Процесс запущен!");
         Thread.Sleep(1000);
         System.Console.WriteLine("Процесс успешно завершен!");
 
         OnCompleted?.Invoke();
     }
 }
 
 class Box<T>
 {
     public T value { get; set; }
 
     public void Print()
     {
         System.Console.WriteLine($"В коробке: {value}");
     }
 }
 
 public class Animal {}
 public class Dog : Animal {}
 
 public class AnimalBox<T> where T : Animal
 {
     public T value { get; set; }
 }


 //b

 static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static bool IsLongString(string str)
        {
            return str.Length > 5;
        }

        static T[] FilterCollection<T>(T[] collection, Predicate<T> predicate)
        {
            return collection.Where(predicate).ToArray();
        }

        static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

//c
public class BankAccount
    {
        public event EventHandler<BalanceChangedEventArgs> BalanceChanged;

        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set
            {
                decimal oldBalance = balance;
                balance = value;
                OnBalanceChanged(oldBalance);
            }
        }

        protected virtual void OnBalanceChanged(decimal oldBalance)
        {
            BalanceChanged?.Invoke(this, new BalanceChangedEventArgs(oldBalance, Balance));
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете.");
            }
        }
    }

    public class BalanceChangedEventArgs : EventArgs
    {
        public decimal OldBalance { get; }
        public decimal NewBalance { get; }

        public BalanceChangedEventArgs(decimal oldBalance, decimal newBalance)
        {
            OldBalance = oldBalance;
            NewBalance = newBalance;
        }
    }