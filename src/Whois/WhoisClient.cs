using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace Whois;

internal partial class WhoisClient
{
    private const int WhoisPort = 43;
    private const string InitialServer = "whois.iana.org";
    private const int ReceiveTimeout = 5000; // 5 секунд

    private readonly string _initialServer;
    private readonly int _port;

    public WhoisClient()
    {
        _initialServer = InitialServer;
        _port = WhoisPort;
    }

    public WhoisClient(string initialServer, int port = WhoisPort)
    {
        _initialServer = initialServer;
        _port = port;
    }

    public string Query(IPAddress address)
    {
        return QueryRecursive(_initialServer, _port, address.ToString());
    }

    public static string QueryRecursive(string server, int port, string query)
    {
        string response = SendRequest(server, port, query);

        // Ищем в ответе строку перенаправления (например: "refer: whois.ripe.net" или "whois: whois.arin.net")
        var nextServer = ExtractReferralServer(response);

        // Если нашли новый сервер и он не совпадает с текущим — идем глубже
        if (!string.IsNullOrEmpty(nextServer) && nextServer != server)
        {
            return QueryRecursive(nextServer, port, query);
        }

        return response;
    }

    private static string SendRequest(string server, int port, string query)
    {
        try
        {
            using var client = new TcpClient();
            // Устанавливаем тайм-аут, чтобы не ждать вечно
            client.Connect(server, port);
            client.ReceiveTimeout = ReceiveTimeout;

            using NetworkStream stream = client.GetStream();
            byte[] queryBytes = Encoding.ASCII.GetBytes($"{query}\r\n");
            stream.Write(queryBytes, 0, queryBytes.Length);

            using var reader = new StreamReader(stream, Encoding.UTF8);
            var response = reader.ReadToEnd();
            return response;
        }
        catch (Exception ex)
        {
            return $"[Ошибка при подключении к {server}]: {ex.Message}";
        }
    }

    private static string? ExtractReferralServer(string response)
    {
        // Регулярное выражение для поиска полей refer или whois
        // Ищет строки вида "refer: whois.ripe.net"
        var match = WhoisRegex().Match(response);

        if (match.Success)
        {
            return match.Groups[1].Value.Trim();
        }

        return null;
    }

    public static Dictionary<string, string> Parse(string response)
    {
        var result = new Dictionary<string, string>();
        var lines = response.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        var comments = new StringBuilder();
        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }
            if (line[0] == '%')
            {
                _ = comments.AppendLine(line);
                continue;
            }
            int index = line.IndexOf(':');
            if (index > 0)
            {
                string key = line[..index].Trim();
                string value = line[(index + 1)..].Trim();
                result[key] = value;
            }
        }
        result["#comments"] = comments.ToString();
        return result;
    }

    [GeneratedRegex(@"(?:refer|whois|Whois Server):\s*([\w\.*\-*\s]+)\n", RegexOptions.IgnoreCase, "en")]
    private static partial Regex WhoisRegex();
}
