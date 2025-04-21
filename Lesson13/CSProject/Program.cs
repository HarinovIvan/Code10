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
    }
}