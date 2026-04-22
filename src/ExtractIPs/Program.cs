// <copyright file="Program.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.CommandLine;
using Microsoft.Extensions.FileSystemGlobbing;
using Microsoft.Extensions.FileSystemGlobbing.Abstractions;

namespace ExtractIPs;

internal class Program
{
    private static readonly Option<IEnumerable<string>> _includeOption = new("--include", "-i")
    {
        Description = "Путь к файлу логов",
        Required = true,
        Arity = ArgumentArity.OneOrMore
    };
    private static readonly Option<IEnumerable<string>> _excludeOption = new("--exclude", "-e")
    {
        Description = "Путь к файлу логов",
        Required = false,
        Arity = ArgumentArity.OneOrMore
    };
    private static readonly Option<string> _searchRootOption = new("--search-root", "-r")
    {
        Description = "The root directory for the search",
        Required = false,
        DefaultValueFactory = (_) => Directory.GetCurrentDirectory()
    };
    private static readonly Option<string> _searchTargetOption = new("--search-target", "-s")
    {
        Description = "Фраза для поиска в логах",
        Required = false,
        DefaultValueFactory = (_) => "535 Authentication failed. Too many invalid logon attempts."
    };

    private static readonly RootCommand _rootCommand = new("Extract IPs from log files")
    {
        _includeOption,
        _excludeOption,
        _searchRootOption,
        _searchTargetOption
    };

    private static void Main(string[] args)
    {
        var parseResult = _rootCommand.Parse(args);

        var includePatterns = parseResult.GetValue(_includeOption)!;
        var excludePatterns = parseResult.GetValue(_excludeOption);
        var searchRoot = parseResult.GetValue(_searchRootOption)!;
        var searchTarget = parseResult.GetValue(_searchTargetOption);

        Matcher matcher = new();
        matcher.AddIncludePatterns(includePatterns);
        if (excludePatterns != null)
        {
            matcher.AddExcludePatterns(excludePatterns);
        }

        var result = matcher.Execute(new DirectoryInfoWrapper(new DirectoryInfo(searchRoot)));

        if (result.HasMatches)
        {
            IPsExtractor extractor = new(searchTarget);
            Dictionary<string, long> uniqueIps = [];
            foreach (var match in result.Files)
            {
                var filePath = Path.Combine(searchRoot, match.Path);
                var ips = extractor.ExtractIPsAsync(filePath).Result;
                foreach (var kvp in ips)
                {
                    if (uniqueIps.TryGetValue(kvp.Key, out var value))
                    {
                        uniqueIps[kvp.Key] = value + kvp.Value;
                    }
                    else
                    {
                        uniqueIps.Add(kvp.Key, kvp.Value);
                    }
                }
            }
            foreach (var ip in uniqueIps.OrderByDescending(t => t.Value))
            {
                Console.WriteLine($"{ip.Key}: {ip.Value}");
            }
        }
    }
}
