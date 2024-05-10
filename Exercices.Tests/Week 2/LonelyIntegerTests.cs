using Exercices.Week_2;
using Xunit;

namespace Exercices.Tests.Week_2
{
    public class LonelyIntegerTests
    {
        [Theory]
        [InlineData(new[] { 1,2,3,4,1,2,3,5,6,5,7,7,6,3,6 },4)]
        public void ShouldReturnOk(int[] input, int output)
        {
            var result = LonelyInteger.Solution(input.ToList());
            Assert.Equal(output, result);

        }
    }
}
