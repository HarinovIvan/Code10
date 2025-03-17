# Теория

### `get`, `set`

**`get`, `set`** - управление свойствами объектов (то есть инкапсуляция).\
`get` - возвращает (читает) значение свойства\
`set` – устанавливает (изменяет) значение свойства

Пример:
```csharp
class Person
{
    private string name; // Приватное поле

    public string Name
    {
        get { return name; } // Получение значения
        set
        {
            if (!string.IsNullOrWhiteSpace(value)) // Проверка на пустую строку
                name = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Name = "Иван"; // Устанавливаем имя
        Console.WriteLine(p.Name); // Иван

        p.Name = ""; // Ошибка! Не изменится, так как пустая строка
        Console.WriteLine(p.Name); // Иван
    }
}
```
Если бы поле было публичным, то туда можно было бы записать что угодно, даже пустое значение\
А если проверка не нужна, то можно использовать автоматическое свойство:
```csharp
class Car
{
    public string Brand { get; set; } // Автоматическое свойство
}
```
Свойство Brand автоматически создаёт скрытое поле и `get`/`set`\
Если для полянужно только чтение (`get`), то можно просто не указывать `set`.

### `base` – Вызов наследованных методов и конструктора

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

### `List<T>` - Динамический список

**`List<T>`** - гибкая коллекция, и в отличии от массивов, она изменяема (то есть можно изменить ее размер)

```csharp
// Объявление списка
List<int> numbers = new List<int>(); // Пустой список типа int

// Добавление элементов
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);

// Вывод элементов на экран
foreach (int num in numbers)
    Console.WriteLine(num);
// 10
// 20
// 30
```

### Основные методы `List<T>`:

.Add(item) - Добавляет элемент в список\
.Remove(item) - Удаляет первое вхождение элемента\
.RemoveAt(index) - Удаляет элемент по индексу\
.Contains(item) - Проверяет, есть ли элемент\
.IndexOf(item) - Возвращает индекс элемента\
.Count - Количество элементов\
.Clear() - Очищает список

### `File`

Класс `File` используется для работы с файлами в C#
#### Важно, `File` содержит статические методы, поэтому создавать объект `File` не нужно

Примеры работы с `File`:
```csharp
// Запись в файл
string path = "example.txt";
string content = "Привет, мир!";
File.WriteAllText(path, content);
Console.WriteLine("Файл записан!");

// Чтение из файла
string text = File.ReadAllText("example.txt");
Console.WriteLine(text); // Привет, мир!

// Если необходимо читать из файла построчно:
string[] lines = File.ReadAllLines("example.txt");

foreach (string line in lines)
    Console.WriteLine(line);

// Добавление текста в конце без очистки файла
File.AppendAllText("example.txt", "\nДобавленный текст.");

// Проверка, существует ли файл
if (File.Exists("example.txt"))
    Console.WriteLine("Файл найден!");
else
    Console.WriteLine("Файл не существует.");

// Копирование и перемещение файла
File.Copy("example.txt", "copy.txt", true); // true → перезаписать, если файл существует
File.Move("copy.txt", "moved.txt"); // Переименование / перемещение

// Удаление файла
if (File.Exists("example.txt"))
    File.Delete("example.txt");
```

# Практика

**Практика A:**\
Реализовать чтение и запись в файл Test.txt.

**Практика B:**\
Расширить решение предыдущего урока за счет  сервиса по чтению и записи в файл

**Практика С:**\
Реализовать запись в файл в MD формате
