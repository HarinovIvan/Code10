<<<<<<< HEAD
﻿using System.Reflection;
using System.Runtime.InteropServices;

public delegate double MathOperation(double x, double y);
=======
﻿using System.Runtime.InteropServices.Swift;
using System.Security.Cryptography;

// public delegate void MessageHandler();

// public class Publisher
// {
//     public event MessageHandler MessageSent;

//     public void SendMessage()
//     {
//         System.Console.WriteLine("Сообщение отправлено");
//         MessageSent?.Invoke();
//     }
// }

// public class Subscriber
// {
//     public void OnMessage()
//     {
//         System.Console.WriteLine("Подписчик получил сообщение");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Publisher publisher = new Publisher();
//         Subscriber subscriber = new Subscriber();

//         publisher.MessageSent += subscriber.OnMessage; // подписка на событие

//         publisher.SendMessage();
//     }
// }
     

public delegate void ClickHandler();

public class Button
{
    public ClickHandler OnClick;

    public void Click()
    {
        System.Console.WriteLine("Кнопка нажата");
        OnClick?.Invoke();
    }
}

public class Window
{
    public void ShowWindow()
    {
        System.Console.WriteLine("|-------|");
        System.Console.WriteLine("|   OK  |");
        System.Console.WriteLine("|       |");
        System.Console.WriteLine("|-------|");
    }
}
>>>>>>> upstream/main

class Program
{
    public static double Add(double x, double y)
    {
<<<<<<< HEAD
        return x + y;
    }

    public static double Multiply(double x, double y)
    {
        return x * y;
    }

    public static double ExecuteOperation(MathOperation operation, double x, double y)
    {
        return operation(x, y);
    }

    public static void Main()
    {
        MathOperation handler = Multiply;
        double i = ExecuteOperation(handler, 5, 5);
        Console.WriteLine(i);
        handler = Add;
        i = ExecuteOperation(handler, 5, 5);
        Console.WriteLine(i);

        TemperatureSensor sensor = new TemperatureSensor();
        
        sensor.TemperatureChanged += (send, temp) => 
        {
            System.Console.WriteLine($"Температура: {temp} C");
        };
        
        sensor.UpdateTemperature(50);
        sensor.UpdateTemperature(30);
        sensor.UpdateTemperature(84);
        sensor.UpdateTemperature(14);
        sensor.UpdateTemperature(43);
    }

    //C
    Stock stock = new Stock();

        stock.PriceChanged += (sender, e) =>
        {
            Console.WriteLine("Цена изменилась!");
        };

        stock.PriceChanged += (sender, e) =>
        {
            Console.WriteLine("Новая цена: " + ((Stock)sender).Price);
        };

        stock.ChangePrice(123.5);
        stock.ChangePrice(89.0);
}



class TemperatureSensor
{
    private double _Temperature;
    public double Temperature => _Temperature; 
    public event EventHandler<double> TemperatureChanged;

    public void UpdateTemperature(double newTemperature)
    {
        if (newTemperature != _Temperature)
        {
            _Temperature = newTemperature;

            TemperatureChanged?.Invoke(this, _Temperature);
        }
    }
}

class Stock
    {
        private double price;

        //1
        public double Price
        {
            if (price != newPrice)
            {
                newPrice = price;
                OnPriceChanged();
            }
            
        }

        //2
        public event EventHandler PriceChanged;

        public void ChangePrice(double newPrice)
        {
            Price = newPrice;
        }

        protected virtual void OnPriceChanged()
        {
            PriceChanged?.Invoke(this, EventArgs.Empty);
        }
    }
=======
        Button button = new Button();
        Window window = new Window();

        button.OnClick += window.ShowWindow;

        button.Click();
    }
}
>>>>>>> upstream/main
