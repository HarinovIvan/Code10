# Теория

## Наследование

**Наследование** - механизм, который позволяет одному классу (наследнику) унаследовать функциальность другого класса (базового)

### Модификаторы наследования:
**public** - Доступен везде\
**protected** - Доступен внутри класса и в классе-наследнике\
**private** - Доступен только внутри класса

Пример `protected`:
```csharp
class Animal
{
    protected void ProtectedMethod()
    {
        Console.WriteLine("Я защищенный метод!");
    }
}

class Dog : Animal
{
    public void CallProtected()
    {
        ProtectedMethod(); // Доступен, так как он protected
    }
}
```

## `base` – Вызов наследованных методов и конструктора

`base` используется в наследовании, чтобы обращаться к членам наследованного класса

Пример с методами:
```csharp
class Animal
{
    public void Speak()
    {
        Console.WriteLine("Животное издаёт звук");
    }
}

class Dog : Animal
{
    public void SpeakLoud()
    {
        base.Speak(); // Вызов наследованного метода
        Console.WriteLine("Гав-гав!");
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.SpeakLoud();
        // Животное издаёт звук
        // Гав-гав!
    }
}
```
Ключевое слово `base` вызывает метод `Speak()` из класса `Animal`.

Пример с конструкторами:
```csharp
class Animal
{
    public string Name;
    
    // Оригинальный конструктор
    public Animal(string name)
    {
        Name = name;
    }
}

class Dog : Animal
{
    public string Breed;
    
    // Конструктор потомка вызывает `base(name)`
    public Dog(string name, string breed) : base(name)
    {
        Breed = breed;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Собака {Name}, порода {Breed}");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog("Бобик", "Лабрадор");
        myDog.ShowInfo(); // Собака Бобик, порода Лабрадор
    }
}
```

## Полиморфизм

**Полиморфизм** - способность методов иметь разное поведение в зависимости от контекста. Это позволяет переопределять методы родителя в дочернем классе или использовать интерфейсы

### Виды полиморфизма:
1. Переопределение методов (Override) – Динамический полиморфизм\
Если метод в родительском классе виртуальный (virtual), его можно переопределить в дочернем (override):
```csharp
class Animal
{
    public virtual void MakeSound() // Виртуальный метод
    {
        Console.WriteLine("Животное издает звук");
    }
}

class Dog : Animal
{
    public override void MakeSound() // Переопределение метода
    {
        Console.WriteLine("Собака лает: Гав-гав!");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Dog();
        myAnimal.MakeSound(); // Собака лает: Гав-гав!
    }
}
```
Метод `MakeSound()` в `Dog` заменяет (override) родительский метод\
При вызове `myAnimal.MakeSound()` работает метод из `Dog`, а не `Animal`

2. Перегрузка методов (Overloading) – Статический полиморфизм
Методы могут иметь одно имя, но разные параметры:
```csharp
class MathOperations
{
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
    public int Add(int a, int b, int c) => a + b + c;
}

class Program
{
    static void Main()
    {
        MathOperations math = new MathOperations();
        Console.WriteLine(math.Add(5, 10));      // 15
        Console.WriteLine(math.Add(5.5, 2.3));   // 7.8
        Console.WriteLine(math.Add(1, 2, 3));    // 6
    }
}
```

## Абстрактные классы и интерфейсы в полиморфизме

### Абстрактные классы (`abstract`)
Абстрактный класс - класс, который нельзя создать напрямую (`new`). Он существует только для наследования
```csharp
abstract class Animal
{
    public abstract void MakeSound(); // Абстрактный метод (без реализации)
}

class Dog : Animal
{
    public override void MakeSound() 
    {
        Console.WriteLine("Собака лает: Гав-гав!");
    }
}
```
Обязательное переопределение метода `MakeSound` в дочернем классе.

# Практика

**Практика A**  

1. Создайте абстрактный класс Creature с полями Name и Health.
2. Добавьте абстрактный метод Attack без реализации и виртуальный метод TakeDamage для обработки полученного урона. TakeDamage в аргументах долен принимать значение урона и вычитать его из здоровья, если получается значение меньше нуля, здоровье устанавливать в 0.

**Практика B**

1. Создайте класс Hero, который наследуется от Creature. Добавьте поле AttackPower и реализуйте метод Attack для атаки других существ. Метод Attack принимает сущность, которую атакует, выводит информацию в таком виде:  
`Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage!");`  
и наносит урон (функцию нанесения урона вы уже написали на предыдущем шаге).
2. Создайте класс Monster, который наследуется от Creature. Добавьте поле AttackPower и реализуйте метод Attack для атаки цели. По аналогии с классом Hero.
3. Создайте класс Item с полями Name и Description, а также виртуальным методом Use для использования предмета. Метод Use принимает игрока (Hero) и выводит информацию в таком виде:  
`Console.WriteLine($"Using {Name}: {Description}");`

**Практика C**

1. Добавьте класс HealingPotion (зелье лечения), который наследуется от Item. Добавьте приватное поле для количества лечения и переопределите метод Use для увеличения здоровья героя.
2. Добавьте класс Game, который уже реализован [ССЫЛКА](PracticeC.cs).
3. В Program.cs объявите класс Game и вызовите функцию Play.
4. Поэкспериментируйте со значенимя в конструкторе Game.