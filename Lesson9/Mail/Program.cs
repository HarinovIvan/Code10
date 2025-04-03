namespace MailService;

public class Letter
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Заголовок
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Тело письма
    /// </summary>
    public string Body { get; set; }
    
    /// <summary>
    /// Новое ли письмо
    /// </summary>
    public bool IsNew { get; set; }
    
    /// <summary>
    /// Во сколько письмо было получено
    /// </summary>
    public DateTime Received { get; set; }
}

public class Mail
{
    public Mail(string email)
    {
        Email = email;
        Letters = new List<Letter>();
    }
    
    public string Email { get; set; }
    
    public List<Letter> Letters { get; set; }

    public void CreateRandomLetters(int count)
    {
        var currentCount = Letters.Count;
        
        for (int i = currentCount; i < currentCount + count; i++)
        {
            Letters.Add(new Letter
            {
                Id = i,
                Title = $"Title {i}",
                Body = $"Body {i}",
                IsNew = i % 2 == 0,
                Received = DateTime.Now.AddMinutes(i % 2 > 0 ? i : -i)
            });
        }
    }
    
    public List<int> GetNewLetterIds_Classic()
    {
        var res = new List<int>();
        for(int i = 0; i < Letters.Count; i++)
        {
            if (Letters[i].IsNew)
                res.Add(Letters[i].Id);
        }
        return res;
    }
    
    public List<int> GetNewLetterIds_Linq()
    {
        // TODO: Задание B1. напишите здесь linq запрос
        throw new NotImplementedException(); // заглушка, надо убрать
    }
    
    public void SortByRecived_Classic()
    {
        for (int i = 0; i < Letters.Count - 1; i++)
        {
            for (int j = i + 1; j < Letters.Count; j++)
            {
                if (Letters[i].Received > Letters[j].Received)
                {
                    Letter temp = Letters[i];
                    Letters[i] = Letters[j];
                    Letters[j] = temp;
                }
            }
        }
    }
    
    public void SortByRecived_Linq()
    {
        // TODO: Задание B2. напишите здесь linq запрос
        throw new NotImplementedException(); // заглушка, надо убрать
    }
}

public class Program
{
    // список почтовых ящиков (C)
    private static readonly List<MailService.Mail> Mails = new List<MailService.Mail>()
    {
        new MailService.Mail("user1@mail.com"),
        new MailService.Mail("user2@mail.com"),
        new MailService.Mail("user3@mail.com"),
        new MailService.Mail("user4@mail.com"),
        new MailService.Mail("user5@mail.com"),
    };

    public static void Main(string[] args)
    {
        // почтовый ящик пользователя
        var mail = new MailService.Mail("user1@mail.com");
        mail.CreateRandomLetters(10);
        
        // Получение количества новых писем
        var countNewLetters_classic = mail.GetNewLetterIds_Classic();
        Console.WriteLine($"Количество новых писем (Classic): {countNewLetters_classic.Count}");
        
        var countNewLetters_linq = mail.GetNewLetterIds_Linq();
        Console.WriteLine($"Количество новых писем (Linq): {countNewLetters_linq.Count}");
        
        // Сортировка писем по дате получения
        // TODO: Задание B2. для mail вызовите метод SortByRecived_Linq и выведите полученные письма
        



        foreach (var email in Mails)
        {
            email.CreateRandomLetters(10);
        }
        
        // TODO: Практика C1. Найти старые письма (!IsNew) с почтовым ящиком user1@mail.com 
        

        // TODO: Практика C2. Найти время самого нового письма (Received) для почтового ящика user4@mail.com
        

    }
}