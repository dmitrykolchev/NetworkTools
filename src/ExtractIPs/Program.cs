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
        Description = "Include patterns for files to search",
        Required = true,
        Arity = ArgumentArity.OneOrMore
    };
    private static readonly Option<IEnumerable<string>> _excludeOption = new("--exclude", "-e")
    {
        Description = "Exclude patterns for files to search",
        Required = false,
        Arity = ArgumentArity.ZeroOrMore
    };
    private static readonly Option<string> _searchRootOption = new("--search-root", "-r")
    {
        Description = "The root directory for the search",
        Required = false,
        DefaultValueFactory = (_) => Directory.GetCurrentDirectory()
    };
    private static readonly Option<string> _searchTargetOption = new("--search-target", "-s")
    {
        Description = "The phrase to search for in the log files",
        Required = false,
        DefaultValueFactory = (_) => "535 Authentication failed. Too many invalid logon attempts."
    };

    private static readonly RootCommand _rootCommand = new("Extract IPs from log files")
    {
        _includeOption,
        _excludeOption,
        _searchRootOption,
        _searchTargetOption,
    };

    private static async Task Main(string[] args)
    {
        _rootCommand.SetAction(InvokeRootCommand);
        await _rootCommand.Parse(args).InvokeAsync();
    }

    private static void InvokeRootCommand(ParseResult parseResult)
    {
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
            foreach (var ip in uniqueIps.OrderBy(t => ToIPv4Int(t.Key)))
            {
                Console.WriteLine($"| {ip.Key,-16} | {ip.Value,6} |");
            }
            static long ToIPv4Int(string ip)
            {
                var parts = ip.Split('.').Select(byte.Parse).ToArray();
                return (long)parts[0] << 24 | (long)parts[1] << 16 | (long)parts[2] << 8 | parts[3];
            }
        }
    }
}
