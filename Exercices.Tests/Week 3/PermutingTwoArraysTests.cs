using Exercices.Week_3;
using Xunit;

namespace Exercices.Tests.Week_3
{
    public class PermutingTwoArraysTests
    {
        [Theory]
        [InlineData(1, new[] { 0, 1 }, new[] { 0, 2 }, "YES")]
        [InlineData(10, new[] { 2, 1, 3 }, new[] { 7, 8, 9 }, "YES")]
        [InlineData(5, new[] { 1, 2, 2, 1 }, new[] { 3, 3, 3, 4 }, "NO")]
        public void ShouldReturnOk(int K,int[] A, int[] B, string output)
        {
            var result = PermutingTwoArrays.Solution(K,A.ToList(),B.ToList());
            Assert.Equal(output, result);

        }
    }
}
