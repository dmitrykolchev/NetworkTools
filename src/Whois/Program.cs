using System.Net;
using Xobex.Net.Whois;

namespace Whois;

internal class Program
{
    private static async Task Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("whois domainname|address");
            return;
        }
        string? addressOrName = args[0];
        if (string.IsNullOrWhiteSpace(addressOrName))
        {
            Console.WriteLine("Ошибка: IP не может быть пустым.");
            return;
        }
        var client = new WhoisClient();
        string result;
        if (IPAddress.TryParse(addressOrName, out IPAddress? address))
        {
            // If IP-address, query the IP
            Console.WriteLine($"Queried address: {address}");
            result = await client.QueryAsync(address, CancellationToken.None);
        }
        else
        {
            Console.WriteLine($"Queried name: {addressOrName}");
            Console.WriteLine();
            result = await client.QueryAsync(addressOrName, CancellationToken.None);
        }
        Console.WriteLine("Original Whois response");
        Console.WriteLine("=======================");
        Console.WriteLine();
        Console.WriteLine(result);

        var whoisInfo = WhoisClient.Parse(result);
        Console.WriteLine("Parsed Whois information");
        Console.WriteLine("========================");
        Console.WriteLine();
        foreach (var item in whoisInfo)
        {
            Console.WriteLine($"{item.Key}:\t{item.Value}");
        }
    }
}


