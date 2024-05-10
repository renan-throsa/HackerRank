using Exercices.Week_1;
using Xunit;

namespace Exercices.Tests.Week_1
{
    public class SparseArraysTests
    {
        [Theory]
        [InlineData(new[] { "ab", "ab", "abc" }, new[] { "ab", "abc", "bc" }, new[] { 2,1,0 })]
        public void ShouldReturnOk(string[] strings, string[] queries, int[] output)
        {
            var result = SparseArrays.Solution(strings.ToList(), queries.ToList());
            Assert.Equal(output, result);

        }
    }
}
