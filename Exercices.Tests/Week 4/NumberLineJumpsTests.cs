using Exercices.Week_4;
using Xunit;

namespace Exercices.Tests.Week_4
{
    public class NumberLineJumpsTests
    {
        [Theory]        
        [InlineData(0, 3, 4, 2, "YES")]
        [InlineData(0, 2, 5, 3, "NO")]
        [InlineData(14, 4, 98, 2, "YES")]
        [InlineData(21, 6, 47, 3, "NO")]
        public void ShouldReurnOk(int x1, int v1, int x2, int v2, string output)
        {
            var result = NumberLineJumps.Solution(x1, v1, x2, v2);
            Assert.Equal(output, result);

        }
    }
}
