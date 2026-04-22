// <copyright file="IPsExtractor.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Text.RegularExpressions;

namespace ExtractIPs;

internal partial class IPsExtractor
{
    public IPsExtractor(string? searchTarget)
    {
        SearchTarget = searchTarget;
    }

    public string? SearchTarget { get; }

    public async Task<Dictionary<string, long>> ExtractIPsAsync(string logFilePath)
    {
        Dictionary<string, long> ips = [];
        Spinner spinner = new();
        var count = 0;
        await foreach (var line in File.ReadLinesAsync(logFilePath))
        {
            var ip = ExtractIPFromLine(line);
            if (ip is not null)
            {
                if (!ips.TryGetValue(ip, out var value))
                {
                    ips[ip] = 1;
                }
                else
                {
                    ips[ip] = ++value;
                }
            }
            spinner.Turn($"Извлечение IP из {logFilePath}");
            count++;
        }
        Spinner.Done($"Обработано {count} строк.");
        return ips;
    }

    private string? ExtractIPFromLine(string line)
    {
        if (!string.IsNullOrEmpty(SearchTarget) && line.Contains(SearchTarget))
        {
            var result = IPv4Pattern().Matches(line);
            if (result.Count > 0)
            {
                return result[0].Value;
            }
        }
        return null;
    }

    [GeneratedRegex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b")]
    private static partial Regex IPv4Pattern();
}
