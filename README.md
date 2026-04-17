# Xobex.Net.Whois

Xobex.Net.Whois is a small .NET library for performing WHOIS queries and parsing WHOIS responses. It provides an asynchronous API to query WHOIS servers over TCP and follows referral servers when present.

## Target framework
- .NET 10

## Features
- Asynchronous WHOIS queries (QueryAsync) for domains and IP addresses
- Follows referral (refer / whois / ReferralServer) chains up to a configurable depth
- Simple response parser that extracts header:value pairs and collects comment lines

## Getting started
Requirements:
- .NET 10 SDK

Build the solution from the repository root:

```
dotnet build
```

## Using the library
The library exposes a single primary API surface: the WhoisClient class.

Example (async usage):

```csharp
using System;
using System.Net;
using System.Threading;
using Xobex.Net.Whois;

class Example
{
    public static async Task Main()
    {
        var client = new WhoisClient();
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));

        // Query by domain or IP (string overload)
        string raw = await client.QueryAsync("8.8.8.8", cts.Token);

        // Or query by IPAddress
        // var raw = await client.QueryAsync(IPAddress.Parse("8.8.8.8"), cts.Token);

        // Parse into key/value pairs
        var fields = WhoisClient.Parse(raw);

        Console.WriteLine("Raw response:\n" + raw);
        Console.WriteLine("Parsed fields:");
        foreach (var kv in fields)
        {
            Console.WriteLine($"{kv.Key}: {kv.Value}");
        }
    }
}
```

## Example project (console)
This repository includes a small example console application in src/Whois that demonstrates using the library. To run the example use:

```
dotnet run --project src/Whois/Whois.csproj -- 8.8.8.8
```

Replace 8.8.8.8 with the address or domain you want to query.

## Notes on behavior
- QueryAsync performs network I/O and may throw OperationCanceledException, TimeoutException or SocketException. Handle these in your calling code.
- Parse returns a case-insensitive dictionary where the last seen header value wins. Comment lines are collected under the #comments key.
- The client follows referrals up to a fixed maximum depth to avoid infinite loops.

## Running tests
Run unit tests with:

```
dotnet test
```

## Contributing
Contributions welcome — open issues or pull requests.

## License
See LICENSE file if present in the repository.
