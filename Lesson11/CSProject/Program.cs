class Program
{
    static void Main()
    {
        //A
        MathOperation addition = Add;
        MathOperation multiplication = Multiply;
        Console.WriteLine("Сложение: " + ExecuteOperation(addition, 1, 4));
        Console.WriteLine("Умножение: " + ExecuteOperation(multiplication, 5, 3));

        //B
        TemperatureSensor sensor = new TemperatureSensor();
        sensor.TemperatureChanged += (sender, e) =>
        {
            Console.WriteLine("Температура изменилась!");
        };

        sensor.UpdateTemperature(30.2);
        sensor.UpdateTemperature(180.0);


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

        //A
        //1
        delegate double MathOperation(double x, double y);

        //2
        static double Add(double x, double y)
        {
            return x + y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }

        //3
        static double ExecuteOperation(MathOperation operation, double x, double y)
        {
            return operation(x, y);
        }
    
}

//B
class TemperatureSensor
    {
        private double temperature;

        //1
        public double Temperature
        {
            get { return temperature; }
            set
            {
                if (temperature != value)
                {
                    temperature = value;
                    OnTemperatureChanged();
                }
            }
        }

        //2
        public event EventHandler TemperatureChanged;

        public void UpdateTemperature(double newTemperature)
        {
            Temperature = newTemperature;
        }

        protected virtual void OnTemperatureChanged()
        {
            TemperatureChanged?.Invoke(this, EventArgs.Empty);
        }
    }


//C
class Stock
    {
        private double price;

        //1
        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    OnPriceChanged();
                }
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