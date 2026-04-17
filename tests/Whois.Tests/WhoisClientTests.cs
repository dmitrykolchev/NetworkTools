using System;
using Xunit;
using Whois;

namespace Whois.Tests
{
    public class WhoisClientTests
    {
        [Fact]
        public void Query_ThrowsOnNullOrEmpty()
        {
            var client = new WhoisClient();
            Assert.Throws<ArgumentNullException>(() => client.Query((string)null));
            Assert.Throws<ArgumentException>(() => client.Query(""));
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
}
