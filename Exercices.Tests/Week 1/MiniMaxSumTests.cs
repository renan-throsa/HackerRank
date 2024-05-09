using Exercices.Week_1;
using Xunit;

namespace Exercices.Tests
{
    public class MiniMaxSumTests
    {
        [Fact]
        public void ShouldReturnOkWithSmallNumbers()
        {
            var data = new List<int>() { 9, 3, 5, 7, 1 };
            var result = MiniMaxSum.Solution(data);
            var expected = new long[] { 16,24 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldReturnOkWithLargeNumbers()
        {
            var data = new List<int>() { 256741038, 623958417, 467905213, 714532089, 938071625 };
            var result = MiniMaxSum.Solution(data);
            var expected = new long[] { 2063136757, 2744467344 };
            Assert.Equal(expected, result);
        }
    }
}
