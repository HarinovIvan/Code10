# Теория

## Обработка ошибок

**Обработка ошибок** - механиз, позволяющий предотвратить падение программы, когда что-то идет не так

Основные конструкции:
1. `try` - блок кода, который может вызвать ошибку
2. `catch` - блок кода, который выполняется если произошел exception (ошибка) и обрабатывает его
3. `finally` - блок кода, который выполняется всегда, независимо от ошибки
4. `throw` - создает и "выбрасывает" исключения

Примеры:
```csharp
try
{
    int x = 10, y = 0;
    int result = x / y; // Ошибка деления на ноль!
    Console.WriteLine(result);
}
catch (DivideByZeroException ex) // Ловим ошибку деления на ноль
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
catch (Exception ex) // Общий перехват (ловит любые ошибки)
{
    Console.WriteLine($"Что-то пошло не так: {ex.Message}");
}
```
Сначала ловим конкретные ошибки (DivideByZeroException), а в конце — общий Exception.\
Вывод:
```
Ошибка: Попытка деления на ноль.
```

Еще один пример:
```csharp
try
{
    Console.WriteLine("Открываем файл...");
    throw new Exception("Файл поврежден");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
finally
{
    Console.WriteLine("Закрываем файл...");
}
```
Вывод:
```
Открываем файл...
Ошибка: Файл поврежден
Закрываем файл...
```

И еще один:
```csharp
static void CheckAge(int age)
{
    if (age < 18)
        throw new ArgumentException("Возраст должен быть 18 или больше!");
    Console.WriteLine("Доступ разрешен!");
}

try
{
    CheckAge(16);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
```
```
Ошибка: Возраст должен быть 18 или больше!
```

## LINQ

LINQ (Language Integrated Query) - Встроенный язык запросов в C# для работы с коллекциями, масивами, базами данных, XML и другими источниками данных\
LINQ позволяет писать SQL-подобные запаросы прямо в C#, работает с любыми коллекциями и позволяет использовать фильтрацию, сортировку, группировку и агрегацию

Простой пример:
```csharp
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var evenNumbers = numbers.Where(n => n % 2 == 0); // Только четные

        Console.WriteLine("Четные числа: " + string.Join(", ", evenNumbers));
    }
}
```
```
Четные числа: 2, 4, 6, 8, 10
```
Метод `.Where(n => условие)` фильтрует коллекцию.

Существует два синтаксиса LINQ: методический и запросный\
Методический использует цепочки методов (`.Where()`, `.Select()`,`.OrderBy()` и т.д.). Пример:
```csharp
var result = numbers.Where(n => n > 5).OrderBy(n => n);
```
Запросный синтаксис похож на запросы SQL:
```csharp
var result = from n in numbers
             where n > 5
             orderby n
             select n;
```
\
Разбор основных методов:
### Фильтрация (`Where`)
Выберем числа больше 5:
```csharp
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var filtered = numbers.Where(n => n > 5); // [6, 7, 8, 9, 10]
```

### Преобразование (`Select`)
Умножим все числа на 2:
```csharp
var doubled = numbers.Select(n => n * 2); // [2, 4, 6, 8, 10, 12, 14, 16, 18, 20]
```

### Сортировка (`OrderBy` / `OrderByDescending`)
```csharp
var sortedAsc = numbers.OrderBy(n => n);  // [1, 2, 3, ...]
var sortedDesc = numbers.OrderByDescending(n => n);  // [10, 9, 8, ...]

```
### Группировка (`GroupBy`)
Допустим, у нас есть список людей:
```csharp
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

var people = new List<Person>
{
    new Person { Name = "Аня", Age = 25 },
    new Person { Name = "Борис", Age = 30 },
    new Person { Name = "Вика", Age = 25 },
};
```
Сгруппируем людей по возрасту:
```csharp
var grouped = people.GroupBy(p => p.Age);
foreach (var group in grouped)
{
    Console.WriteLine($"Возраст: {group.Key}");
    foreach (var person in group)
    {
        Console.WriteLine($" - {person.Name}");
    }
}
```
Вывод:
```markdown
Возраст: 25
 - Аня
 - Вика
Возраст: 30
 - Борис
```

### Чтение из файла + LINQ
Читаем только строки, содержащие "ERROR":
```csharp
var lines = File.ReadAllLines("log.txt");
var errors = lines.Where(line => line.Contains("ERROR"));
```
Теперь в errors будут только строки с ошибками.

# Практика

**Практика А**

1. Попробуйте поделить на ноль и добавьте обработку исключений для случая деления на ноль. В этом случае программа должна выводить сообщение об ошибке и продолжать выполнение.
2. Запросите у пользователя число и обработайте ошибку, если ввод некорректен (ввод не является числом или т.д.). 

### Практика B и C выполняется в проекте Mail

**Практика В**

1. Допишите метод GetNewLetterIds_Linq. Проверьте, что метод возвращает такое же количество новых писем, как и GetNewLetterIds_Classic.
2. Допишите метод SortByRecived_Linq. В функции Main проверьте корректность работы вашего метода.

**Практика C**

3. Найти старые письма (!IsNew) с почтовым ящиком user1@mail.com
4. Найти время самого нового письма (Received) для почтового ящика user4@mail.com
