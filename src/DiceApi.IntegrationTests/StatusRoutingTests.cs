using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using Xunit;

namespace DiceApi.IntegrationTests
{
    public class StatusRoutingTests
    {
        [Fact]
        public async Task RoutingToStatusEndpointGivesStatusResponse()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            var client = server.CreateClient();

            var response = await client.GetAsync("/api/status");
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            Assert.Equal("OK", responseString);
        }
    }
}
