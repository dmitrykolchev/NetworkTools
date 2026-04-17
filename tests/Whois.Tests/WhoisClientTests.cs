using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Whois.Tests;

public class WhoisClientTests
{
    [Fact]
    public async Task Query_ThrowsOnNullOrEmpty()
    {
        var client = new WhoisClient();
        _ = await Assert.ThrowsAsync<ArgumentNullException>(() => client.QueryAsync(default(string), CancellationToken.None));
        _ = await Assert.ThrowsAsync<ArgumentException>(() => client.QueryAsync("", CancellationToken.None));
        _ = await Assert.ThrowsAsync<ArgumentNullException>(() => client.QueryAsync(default(IPAddress), CancellationToken.None));
    }

    [Fact]
    public void Parse_ParsesKeyValueAndComments()
    {
        var response = "Domain Name: example.com\r\nRegistrar: ExampleReg\r\n% This is a comment\r\nRefer: whois.ripe.net\r\n";
        var dict = WhoisClient.Parse(response);

        Assert.Equal("example.com", dict["Domain Name"]);
        Assert.Equal("ExampleReg", dict["Registrar"]);
        Assert.True(dict.ContainsKey("#comments"));
        Assert.Contains("% This is a comment", dict["#comments"]);
        Assert.Equal("whois.ripe.net", dict["Refer"]);
    }

    [Fact]
    public void Parse_IsCaseInsensitive_LastValueWins()
    {
        var response = "OrgName: First\r\norgname: Second\r\n";
        var dict = WhoisClient.Parse(response);

        // Key lookup should be case-insensitive and last value should win
        Assert.Equal("Second", dict["OrgName"]);
        Assert.Equal("Second", dict["orgname"]);
    }
}
