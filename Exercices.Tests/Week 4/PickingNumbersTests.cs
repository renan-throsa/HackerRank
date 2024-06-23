using Exercices.Week_4;
using Xunit;

namespace Exercices.Tests.Week_4
{
    public class PickingNumbersTests
    {
        [Theory]        
        [InlineData(new[] { 4, 6, 5, 3, 3, 1 }, 3)]
        [InlineData(new[] { 1, 2, 2, 3, 1, 2 }, 5)]
        [InlineData(new[] { 98, 3, 99, 1, 97, 2 }, 2)]
        public void ShouldReurnOk(int[] input, int output)
        {
            var result = PickingNumbers.Solution(input.ToList());
            Assert.Equal(output, result);

        }
    }
}
