using Exercices.Week_3;
using Xunit;

namespace Exercices.Tests.Week_3
{
    public class SalesbyMatchTests
    {
        [Theory]
        [InlineData(new[] { 1, 2, 1, 2, 1, 3, 2 }, 2)]
        public void ShouldReturnOk(int[] input, int output)
        {
            var result = SalesbyMatch.Solution(input.ToList());
            Assert.Equal(output, result);

        }
    }
}
