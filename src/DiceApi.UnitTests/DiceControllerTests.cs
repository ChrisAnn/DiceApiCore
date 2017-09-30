using DiceApi.Controllers;
using Xunit;

namespace DiceApi.UnitTests
{
    public class DiceControllerTests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(100)]
        public void RollingADieGivesANumberBetween1AndTheDieSize(int size)
        {
            var controller = new DiceController();

            var result = controller.Get(size);
            
            Assert.InRange(result, 1, size);
        }
    }
}