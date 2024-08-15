using Exercices.Week_4;
using Xunit;

namespace Exercices.Tests.Week_4
{
    public class TowerBreakersTests
    {
        [Theory]
        [InlineData(2, 2, 2)]
        [InlineData(1, 4, 1)]
        public void ShouldReurnOk(int n, int m, int output)
        {
            var result = TowerBreakers.Solution(n, m);
            Assert.Equal(output, result);

        }
    }
}
