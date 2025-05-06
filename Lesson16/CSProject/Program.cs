using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

string[] hello = {"Привет", "привет", "hello", "Hello"};

using var cts = new CancellationTokenSource();

const string token = "7848789151:AAEhXDH_FoYjhffSemCiPfFkxBmPO4y6o38"; 

var bot = new TelegramBotClient(token, cancellationToken: cts.Token);
var me = await bot.GetMe();
bot.OnMessage += OnMessage;

Console.WriteLine($"@{me.Username} is running... Press Enter to terminate");
Console.ReadLine();
cts.Cancel(); // stop the bot

async Task OnMessage(Message msg, UpdateType type)
{
    if (msg.Text is null) return;
    System.Console.WriteLine($"{type}: {msg.Text}\n{msg.Contact}");
    bool hiFlag = false;
    foreach (var hi in hello)
    {
        if (msg.Text == hi)
        {
            await bot.SendMessage(msg.Chat, "Привет!");
            hiFlag = true;
        }
    }
    if (!hiFlag)
    {
        await bot.SendMessage(msg.Chat, msg.Text);
    }
}