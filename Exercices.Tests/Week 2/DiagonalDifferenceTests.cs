using Exercices.Week_2;
using Xunit;

namespace Exercices.Tests.Week_2
{
    public class DiagonalDifferenceTests
    {
        [Fact]
        public void ShouldReturnOk()
        {
            var input = new List<List<int>> {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5, 6 },
            new List<int> { 9, 8, 9 }
        };

            int output = 2;
            var result = DiagonalDifference.Solution(input);
            Assert.Equal(output, result);

        }

        [Fact]
        public void ShouldReturnOkWithNegativeNumbers()
        {
            var input = new List<List<int>> {
            new List<int> { -1, 1, -7, -8 },
            new List<int> { -10, -8, -5, -2 },
            new List<int> { 0, 9, 7, - 1 },
            new List<int> { 4, 4, -2, 1, },
        };

            int output = 1;
            var result = DiagonalDifference.Solution(input);
            Assert.Equal(output, result);

        }
    }
}
