using Exercices.Week_3;
using Xunit;

namespace Exercices.Tests.Week_3
{
    public class SubarrayDivision2Tests
    {
        [Theory]
        [InlineData(new[] { 2, 2, 1, 3, 2 }, 4, 2, 2)]
        public void ShouldReturnOk(int[] S, int D, int M, int output)
        {
            var result = SubarrayDivision2.Solution(S.ToList(), D, M);
            Assert.Equal(output, result);

        }
    }
}
