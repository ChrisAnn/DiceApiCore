using System;
using Xunit;
using DiceApi;
using DiceApi.Controllers;

namespace DiceApi.UnitTests
{
    public class StatusControllerTests
    {
        [Fact]
        public void StatusEndpointReturnsOK()
        {
            StatusController controller = new StatusController();
            var result = controller.Get();

            Assert.Equal(result, "OK");
        }
    }
}
