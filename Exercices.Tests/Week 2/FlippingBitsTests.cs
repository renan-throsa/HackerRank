using Exercices.Week_2;
using Xunit;

namespace Exercices.Tests.Week_2
{
    public class FlippingBitsTests
    {
        [Theory]
        [InlineData(3, 4294967292)]
        [InlineData(2147483647, 2147483648)]
        [InlineData(1, 4294967294)]
        [InlineData(0, 4294967295)]
        public void ShouldReturnOk(long input, long output)
        {
            var result = FlippingBits.Solution(input);
            Assert.Equal(output, result);

        }
    }
}
