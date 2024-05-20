using Exercices.Week_3;
using Xunit;

namespace Exercices.Tests.Week_3
{
    public class ZigZagSequenceTests
    {
        [Theory]
        [InlineData(new[] { 2, 3, 5, 1, 4 }, new[] { 1, 2, 5, 4, 3 })]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 1, 2, 3, 7, 6, 5, 4 })]
        public void ShouldReurnOk(int[] input, int[] output)
        {
            var result = ZigZagSequence.Solution(input);
            Assert.Equal(output, result);

        }
    }
}
