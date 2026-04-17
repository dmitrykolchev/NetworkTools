using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace Xobex.Net.Whois;

/// <summary>
/// A small WHOIS client library capable of querying WHOIS servers over TCP.
/// The client exposes asynchronous methods that perform network I/O and
/// follow referral servers (refer/whois) recursively. Network and cancellation
/// related errors are propagated as exceptions to the caller.
/// </summary>
public partial class WhoisClient
{
    /// <summary>
    /// Default WHOIS TCP port.
    /// </summary>
    private const int WhoisPort = 43;

    /// <summary>
    /// Default initial WHOIS server to query when resolving a referral chain.
    /// </summary>
    private const string InitialServer = "whois.iana.org";

    /// <summary>
    /// Receive timeout in milliseconds used for network reads.
    /// </summary>
    private const int ReceiveTimeout = 5000; // 5 seconds

    /// <summary>
    /// Timeout in milliseconds used when establishing a TCP connection.
    /// </summary>
    private const int ConnectTimeout = 5000; // connection timeout (ms)

    /// <summary>
    /// Maximum referral depth to avoid infinite recursion when following
    /// WHOIS referral servers.
    /// </summary>
    private const int MaxReferralDepth = 8;

    /// <summary>
    /// The initial server to start WHOIS queries from. Usually <see cref="InitialServer"/>.
    /// </summary>
    private readonly string _initialServer;

    /// <summary>
    /// The port used for WHOIS queries. Usually <see cref="WhoisPort"/>.
    /// </summary>
    private readonly int _port;

    /// <summary>
    /// Initializes a new instance of the <see cref="WhoisClient"/> class
    /// using the default initial server and port.
    /// </summary>
    public WhoisClient()
    {
        _initialServer = InitialServer;
        _port = WhoisPort;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="WhoisClient"/> class
    /// with a custom initial server and optional port.
    /// </summary>
    /// <param name="initialServer">The initial WHOIS server to query.</param>
    /// <param name="port">The TCP port to use for WHOIS queries. Defaults to 43.</param>
    public WhoisClient(string initialServer, int port = WhoisPort)
    {
        _initialServer = initialServer;
        _port = port;
    }

    public Task<string> QueryAsync(string query) =>
        QueryAsync(query, CancellationToken.None);

    /// <summary>
    /// Performs an asynchronous WHOIS query for the provided query string starting
    /// from the configured initial server and following referrals if necessary.
    /// </summary>
    /// <param name="query">The query string (domain name or IP) to send to the WHOIS server.</param>
    /// <param name="cancellationToken">Cancellation token used to cancel the operation.</param>
    /// <returns>The raw WHOIS response text.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="query"/> is null.</exception>
    /// <exception cref="ArgumentException">Thrown when <paramref name="query"/> is an empty string.</exception>
    /// <exception cref="OperationCanceledException">Thrown when <paramref name="cancellationToken"/> is canceled.</exception>
    /// <exception cref="TimeoutException">Thrown when the TCP connection times out.</exception>
    /// <exception cref="System.Net.Sockets.SocketException">Thrown for socket-level errors during connect.</exception>
    public Task<string> QueryAsync(string query, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNullOrEmpty(query);
        return QueryRecursiveAsync(_initialServer, _port, query, 0, cancellationToken);
    }

    public Task<string> QueryAsync(IPAddress address) =>
        QueryAsync(address, CancellationToken.None);

    /// <summary>
    /// Performs an asynchronous WHOIS query for the provided IP address starting
    /// from the configured initial server and following referrals if necessary.
    /// </summary>
    /// <param name="address">The IP address to query.</param>
    /// <param name="cancellationToken">Cancellation token used to cancel the operation.</param>
    /// <returns>The raw WHOIS response text.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="address"/> is null.</exception>
    /// <exception cref="OperationCanceledException">Thrown when <paramref name="cancellationToken"/> is canceled.</exception>
    public Task<string> QueryAsync(IPAddress address, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(address);
        return QueryRecursiveAsync(_initialServer, _port, address.ToString(), 0, cancellationToken);
    }

    /// <summary>
    /// Internal recursive asynchronous method that sends the WHOIS request to a server
    /// and follows referral servers up to a maximum depth.
    /// </summary>
    /// <param name="server">The WHOIS server to query.</param>
    /// <param name="port">The TCP port to use.</param>
    /// <param name="query">The query string to send.</param>
    /// <param name="depth">Current recursion depth used to limit referrals.</param>
    /// <param name="cancellationToken">Cancellation token used to cancel the operation.</param>
    /// <returns>The raw WHOIS response text from the final server.</returns>
    /// <exception cref="OperationCanceledException">Thrown when <paramref name="cancellationToken"/> is canceled.</exception>
    /// <exception cref="TimeoutException">Thrown when a connection attempt times out.</exception>
    /// <exception cref="System.Net.Sockets.SocketException">Thrown for socket-level errors during connect or write/read.</exception>
    private static async Task<string> QueryRecursiveAsync(string server, int port, string query, int depth, CancellationToken cancellationToken)
    {
        string response = await SendRequestAsync(server, port, query, cancellationToken);

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
                return await QueryRecursiveAsync(nextServer, port, query, depth + 1, cancellationToken);
            }
        }

        return response;
    }

    /// <summary>
    /// Sends a single WHOIS request asynchronously to the specified server and returns the raw response.
    /// </summary>
    /// <param name="server">The WHOIS server to connect to.</param>
    /// <param name="port">The TCP port to use.</param>
    /// <param name="query">The query string to send.</param>
    /// <param name="cancellationToken">Cancellation token used to cancel the operation.</param>
    /// <returns>The raw server response.</returns>
    /// <exception cref="OperationCanceledException">Thrown when <paramref name="cancellationToken"/> is canceled.</exception>
    /// <exception cref="TimeoutException">Thrown when the TCP connection times out.</exception>
    /// <exception cref="System.Net.Sockets.SocketException">Thrown for socket-level errors during connect or write/read.</exception>
    private static async Task<string> SendRequestAsync(string server, int port, string query, CancellationToken cancellationToken)
    {
        using var client = new TcpClient();
        // Устанавливаем тайм-аут на подключение и на чтение, чтобы не ждать вечно
        await client.ConnectAsync(server, port).WaitAsync(TimeSpan.FromMilliseconds(ConnectTimeout), cancellationToken);
        client.ReceiveTimeout = ReceiveTimeout;
        client.SendTimeout = ConnectTimeout;

        using NetworkStream stream = client.GetStream();
        var queryBytes = Encoding.ASCII.GetBytes($"{query}\r\n");
        await stream.WriteAsync(queryBytes, cancellationToken);

        // Большинство whois-серверов используют ASCII/Latin1. Читаем как ASCII для предсказуемости.
        using var reader = new StreamReader(stream, Encoding.ASCII);
        var response = await reader.ReadToEndAsync(cancellationToken);
        return response;
    }

    /// <summary>
    /// Extracts a referral server (refer, whois, referralserver) from a WHOIS response.
    /// Returns the sanitized server hostname or null when no referral is present.
    /// This method does not perform network I/O and will not throw for normal input; it may throw
    /// an <see cref="ArgumentNullException"/> if <paramref name="response"/> is null.
    /// </summary>
    /// <param name="response">The raw WHOIS response text.</param>
    /// <returns>Sanitized referral server hostname or null.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="response"/> is null.</exception>
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

    /// <summary>
    /// Parses a WHOIS response into a dictionary of key/value pairs. Lines starting
    /// with '%' are collected into the special key "#comments". Keys are case-insensitive.
    /// </summary>
    /// <param name="response">The raw WHOIS response text.</param>
    /// <returns>A dictionary of parsed fields where keys are header names and values are the last seen value.</returns>
    public static Dictionary<string, string> Parse(string response)
    {
        var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        var lines = response.Split(['\n', '\r'], StringSplitOptions.RemoveEmptyEntries);
        var comments = new StringBuilder();
        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }
            if (line[0] is '%' or '#' or ';')
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

    /// <summary>
    /// Compiled regex used to extract referral lines from WHOIS responses. Pattern
    /// matches lines that start with refer, whois (or whois server) or referralserver
    /// and captures the server portion (without scheme or port).
    /// </summary>
    [GeneratedRegex(@"^(?:refer|whois(?:\s+server)?|referralserver):\s*(?:whois://)?\s*([^\s:]+)", RegexOptions.IgnoreCase | RegexOptions.Multiline, "en")]
    private static partial Regex WhoisRegex();

    /// <summary>
    /// Removes known schemes (whois://) and port suffixes from a server string
    /// and trims whitespace.
    /// </summary>
    /// <param name="server">The server string to sanitize.</param>
    /// <returns>Sanitized server hostname without scheme or port.</returns>
    private static string SanitizeServer(string server)
    {
        if (string.IsNullOrWhiteSpace(server))
        {
            return string.Empty;
        }
        server = server.Trim();
        if (server.StartsWith("whois://", StringComparison.OrdinalIgnoreCase))
        {
            server = server["whois://".Length..];
        }
        var idx = server.IndexOf(':');
        if (idx > 0)
        {
            server = server[..idx];
        }
        return server.Trim();
    }

    /// <summary>
    /// Normalizes a server name for comparison by sanitizing and removing a
    /// trailing dot if present.
    /// </summary>
    /// <param name="server">The server name to normalize.</param>
    /// <returns>Normalized server name.</returns>
    private static string NormalizeServerName(string server)
    {
        return SanitizeServer(server).Trim().TrimEnd('.');
    }
}
