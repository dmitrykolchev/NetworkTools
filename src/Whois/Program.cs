using System.Net;

namespace Whois;

internal class Program
{
    private static void Main(string[] args)
    {
        string? ip = args[0];
        if (string.IsNullOrWhiteSpace(ip))
        {
            Console.WriteLine("Ошибка: IP не может быть пустым.");
            return;
        }
        var address = IPAddress.Parse(ip); // Проверка валидности IP
        var client = new WhoisClient();
        string result = client.Query(address);
        var whoisInfo = WhoisClient.Parse(result);

        Console.WriteLine(result);
    }

}


