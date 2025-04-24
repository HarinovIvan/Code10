using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        using HttpClient client = new HttpClient();
        string url = "https://jsonplaceholder.org/posts/1";

<<<<<<< HEAD
        System.Console.WriteLine(response);

        // A

        using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/1");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Ошибка при выполнении запроса: {e.Message}");
                }
            }

        // B
        Console.Write("Введите данные для отправки: ");
            string userInput = Console.ReadLine();

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    StringContent content = new StringContent(userInput, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync("https://jsonplaceholder.typicode.com/posts", content);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Ошибка при выполнении запроса: {e.Message}");
                }
            }
        
        // C

            Console.WriteLine("Выберите тип запроса:");
            Console.WriteLine("Get");
            Console.WriteLine("Post");
            string choice = Console.ReadLine();
            HttpClient client = new HttpClient();

            try
            {
                switch (choice)
                {
                    case "Get":
                        await MakeGetRequest(client);
                        break;
                    case "Post":
                        await MakePostRequest(client);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Ошибка при выполнении запроса: {e.Message}");
            }
        }

        static async Task MakeGetRequest(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/1");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
        }

        static async Task MakePostRequest(HttpClient client)
        {
            Console.WriteLine("Введите данные для отправки: ");
            string userInput = Console.ReadLine();

            StringContent content = new StringContent(userInput, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("https://jsonplaceholder.typicode.com/posts", content);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
        }
}
=======
        var data = new
        {
            id = 100,
            slug = "lorem-ipsum",
            url = "https://jsonplaceholder.org/posts/lorem-ipsum",
            title = "abc",
            content = "testtest",
            image = "https://dummyimage.com/800x430/FFFFFF/lorem-ipsum.png&text=jsonplaceholder.org",
            thumbnail = "https://dummyimage.com/200x200/FFFFFF/lorem-ipsum.png&text=jsonplaceholder.org",
            status = "published",
            category = "lorem",
            publishedAt = "04/02/2023 13:25:21",
            updatedAt = "14/03/2023 17:22:20",
            userId = 1
        };

        string json = JsonSerializer.Serialize(data);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        try
        {
            HttpResponseMessage response = await client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

            // string responseBody = await client.GetStringAsync(url + "00");

            // Dictionary<string, object> responseData = JsonSerializer.Deserialize<Dictionary<string, object>>(responseBody);

            // foreach (var item in responseData)
            // {
            //     System.Console.WriteLine($"{item.Key}: {item.Value}");
            // }
            // System.Console.WriteLine(responseData["title"]);
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }


        // string response = await client.GetStringAsync(url);

        // Dictionary<string, object> data = JsonSerializer.Deserialize<Dictionary<string, object>>(response);

        // foreach (var item in data)
        // {
        //     System.Console.WriteLine($"{item.Key}: {item.Value}");
        // }
        // System.Console.WriteLine(data["title"]);

        // System.Console.WriteLine(response);
    }
}
>>>>>>> upstream/main
