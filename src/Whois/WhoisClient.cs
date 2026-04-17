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
    private const int ConnectTimeout = 5000; // тайм-аут на подключение, мс
    private const int MaxReferralDepth = 8;

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

    public static string QueryRecursive(string server, int port, string query, int depth = 0)
    {
        string response = SendRequest(server, port, query);

        // Ограничение глубины рекурсии перенаправлений
        if (depth >= MaxReferralDepth)
        {
            return response;
        }

        // Ищем в ответе строку перенаправления (например: "refer: whois.ripe.net" или "whois: whois.arin.net")
        var nextServer = ExtractReferralServer(response);

        // Нормализуем и сравниваем без учета регистра
        if (!string.IsNullOrEmpty(nextServer))
        {
            var normalizedCurrent = NormalizeServerName(server);
            var normalizedNext = NormalizeServerName(nextServer);
            if (!string.Equals(normalizedNext, normalizedCurrent, StringComparison.OrdinalIgnoreCase))
            {
                return QueryRecursive(nextServer, port, query, depth + 1);
            }
        }

        return response;
    }

    private static string SendRequest(string server, int port, string query)
    {
        try
        {
            using var client = new TcpClient();
            // Устанавливаем тайм-аут на подключение и на чтение, чтобы не ждать вечно
            var connectTask = client.ConnectAsync(server, port);
            if (!connectTask.Wait(ConnectTimeout))
            {
                throw new TimeoutException($"Тайм-аут подключения к {server}:{port}");
            }
            client.ReceiveTimeout = ReceiveTimeout;
            client.SendTimeout = ConnectTimeout;

            using NetworkStream stream = client.GetStream();
            byte[] queryBytes = Encoding.ASCII.GetBytes($"{query}\r\n");
            stream.Write(queryBytes, 0, queryBytes.Length);

            // Большинство whois-серверов используют ASCII/Latin1. Читаем как ASCII для предсказуемости.
            using var reader = new StreamReader(stream, Encoding.ASCII);
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
        // Регулярное выражение для поиска полей refer, whois или referralserver
        // Ищет строки вида "refer: whois.ripe.net" или "ReferralServer: whois://whois.example.net:43"
        var match = WhoisRegex().Match(response ?? string.Empty);

        if (match.Success)
        {
            var server = match.Groups[1].Value.Trim();
            return SanitizeServer(server);
        }

        return null;
    }

    public static Dictionary<string, string> Parse(string response)
    {
        var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
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

    [GeneratedRegex(@"^(?:refer|whois(?:\s+server)?|referralserver):\s*(?:whois://)?\s*([^\s:]+)", RegexOptions.IgnoreCase | RegexOptions.Multiline, "en")]
    private static partial Regex WhoisRegex();

    private static string SanitizeServer(string server)
    {
        if (string.IsNullOrWhiteSpace(server)) return string.Empty;
        server = server.Trim();
        if (server.StartsWith("whois://", StringComparison.OrdinalIgnoreCase))
        {
            server = server.Substring("whois://".Length);
        }
        var idx = server.IndexOf(':');
        if (idx > 0)
        {
            server = server.Substring(0, idx);
        }
        return server.Trim();
    }

    private static string NormalizeServerName(string server)
    {
        return SanitizeServer(server).Trim().TrimEnd('.');
    }
}
