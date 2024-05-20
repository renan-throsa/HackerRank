using Xunit;

namespace Exercices.Tests.Week_3
{
    public class MigratoryBirdsTests
    {
        [Theory]
        [InlineData(new[] { 1, 1, 2, 2, 3 }, 1)]
        [InlineData(new[] { 1, 4, 4, 4, 5, 3 }, 4)]
        [InlineData(new[] { 2, 4, 3, 2, 3, 1, 2, 1, 3, 3 }, 3)]
        public void ShouldReturnOk(int[] input, int output)
        {
            var result = MigratoryBirds.Solution(input.ToList());
            Assert.Equal(output, result);

        }
    }
}
