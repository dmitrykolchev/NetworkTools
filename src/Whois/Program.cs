using System.Net;
using Xobex.Net.Whois;

namespace Whois;

internal class Program
{
    private static async Task Main(string[] args)
    {
        string? ip = args[0];
        if (string.IsNullOrWhiteSpace(ip))
        {
            Console.WriteLine("Ошибка: IP не может быть пустым.");
            return;
        }
        Console.WriteLine($"Target address: {ip}");
        var address = IPAddress.Parse(ip); // Проверка валидности IP
        var client = new WhoisClient();
        string result = await client.QueryAsync(address, CancellationToken.None);
        var whoisInfo = WhoisClient.Parse(result);

        Console.WriteLine(result);
    }

}


