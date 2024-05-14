using Exercices.Week_2;
using Xunit;

namespace Exercices.Tests.Week_2
{
    public class MarsExplorationTests
    {
        [Theory]
        [InlineData("SOSTOT", 2)]
        [InlineData("SOSSPSSQSSOR", 3)]
        public void ShouldReturnOk(string input, int output)
        {
            var result = MarsExploration.Solution(input);
            Assert.Equal(output, result);

        }
    }
}
