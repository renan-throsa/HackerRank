using Exercices.Week_4;
using Xunit;

namespace Exercices.Tests.Week_4
{
    public class ClosestNumbersTests
    {
        [Theory]
        [InlineData(new[] { 5, 2, 3, 4, 1 }, new[] { 1, 2, 2, 3, 3, 4, 4, 5 })]
        [InlineData(new[] { -5, 15, 25, 71, 63 }, new[] { 63, 71 })]
        [InlineData(new[] { -20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854 }, new[] { -20, 30 })]
        public void ShouldReurnOk(int[] input, int[] output)
        {
            var result = ClosestNumbers.Solution(input.ToList());
            Assert.Equal(output, result);

        }
    }
}
