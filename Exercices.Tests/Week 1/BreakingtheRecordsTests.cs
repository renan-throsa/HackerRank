using Exercices.Week_1;
using Xunit;

namespace Exercices.Tests.Week_1
{
    public class BreakingtheRecordsTests
    {
        [Theory]
        [InlineData(new[] { 12, 23, 10, 25 }, new[] { 2, 1 })]
        [InlineData(new[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 }, new[] { 2, 4 })]
        [InlineData(new[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 }, new[] { 4, 0 })]
        public void ShouldReturnOk(int[] scores, int[] records)
        {

            var result = BreakingtheRecords.Solution(scores);
            Assert.Equal(records, result);

        }

    }
}
