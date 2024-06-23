using Exercices.Week_3;
using Xunit;

namespace Exercices.Tests.Week_3
{
    public class MaximumPerimeterTriangleTests
    {
        [Theory]
        [InlineData(new[] { 1, 1, 1, 3, 3 }, new[] { 1, 3, 3 })]
        [InlineData(new[] { 1, 2, 3 }, new[] { -1 })]
        [InlineData(new[] { 1, 1, 1, 2, 3, 5 }, new[] { 1, 1, 1 })]
        [InlineData(new[] { 3, 9, 2, 15, 3 }, new[] { 2, 3, 3 })]
        public void ShouldReurnOk(int[] input, int[] output)
        {
            var result = MaximumPerimeterTriangle.Solution(input.ToList());
            Assert.Equal(output, result);

        }
    }
}
