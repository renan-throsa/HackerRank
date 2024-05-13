using Exercices.Week_2;

using Xunit;

namespace Exercices.Tests.Week_2
{
    public class CountingValleysTests
    {
        [Theory]
        [InlineData("UDDDUDUU", 1)]
        [InlineData("DUDDDUUDUU", 2)]
        [InlineData("DDUUDDUDUUUD", 2)]
        [InlineData("UDDDUDDDUUUUDU", 2)]
        public void ShouldReturnOk(string input, int output)
        {
            var result = CountingValleys.Solution(input);
            Assert.Equal(output, result);

        }
    }
}
