# Практика A (обязательная): Создание простого Web API

## Задача:
Создайте новый проект ASP.NET Core Web API в Visual Studio.

### Шаги:
1. Добавьте контроллер `HelloController` с методом `Get()`, который возвращает `"Привет, мир!"`.
2. Запустите проект и проверьте работу API через браузер или Postman.

---

# Практика B (усложненная): Создание API для управления списком пользователей

## Задача:
Создайте контроллер `UsersController`.

### Реализация:
1. Реализуйте метод `GetUsers()`, возвращающий список пользователей.
2. Добавьте метод `PostUser()`, который принимает имя пользователя и добавляет его в список.
3. Протестируйте API с помощью Postman.

### Пример кода:
```csharp
[HttpGet]
public IEnumerable<string> GetUsers()
{
    return new List<string> { "Алиса", "Боб", "Чарли" };
}

[HttpPost]
public IActionResult PostUser([FromBody] string name)
{
    return Ok($"Пользователь {name} добавлен!");
}
```

# Практика C (для продвинутых): Добавление базы данных в Web API
Задача:
Подключите Entity Framework Core и реализуйте CRUD-операции.

Шаги:
Создайте модель User с полями Id и Name.

Реализуйте CRUD-методы в UsersController (Create, Read, Update, Delete).

Настройте базу данных SQLite или SQL Server.

Пример модели:
```csharp
Copy
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}
```
Пример CRUD-методов:
Create: Добавление нового пользователя.

Read: Получение списка пользователей или конкретного пользователя по ID.

Update: Обновление данных пользователя.

Delete: Удаление пользователя.

Подключение базы данных:
Используйте Entity Framework Core для работы с базой данных.

Настройте подключение к SQLite или SQL Server в файле appsettings.json.