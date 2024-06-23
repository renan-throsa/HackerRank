
using Exercices.Week_4;
using Xunit;

namespace Exercices.Tests.Week_4
{
    public class LeftRotationTests
    {
        [Theory]
        [InlineData(2, new[] { 1, 2, 3, 4, 5 }, new[] { 3, 4, 5, 1, 2 })]
        [InlineData(10, new[] { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 },
            new[] { 77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77 })]
        public void ShouldReurnOk(int d, int[] input, int[] output)
        {
            var result = LeftRotation.Solution(d, input.ToList());
            Assert.Equal(output, result);

        }
    }
}
