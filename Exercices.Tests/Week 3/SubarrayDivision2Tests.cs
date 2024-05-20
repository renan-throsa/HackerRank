using Exercices.Week_3;
using Xunit;

namespace Exercices.Tests.Week_3
{
    public class SubarrayDivision2Tests
    {
        [Theory]
        [InlineData(new[] { 2, 2, 1, 3, 2 }, 4, 2, 2)]
        [InlineData(new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, 4, 2, 3)]
        public void ShouldReturnOk(int[] S, int D, int M, int output)
        {
            var result = SubarrayDivision2.Solution(S.ToList(), D, M);
            Assert.Equal(output, result);

        }
    }
}
