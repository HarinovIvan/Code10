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
        string response = await client.GetStringAsync(url);

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
