using Exercices.Week_2;
using Xunit;

namespace Exercices.Tests.Week_2
{
    public class GradingStudentsTests
    {
        [Theory]
        [InlineData(new[] { 2, 37, 38 }, new[] { 2, 37, 40 })]
        [InlineData(new[] { 4, 73, 67, 38, 33 }, new[] { 4, 75, 67, 40, 33 })]
        [InlineData(new[] { 23, 80, 96, 18, 73, 78, 60, 60, 15, 45, 15, 10, 5, 46, 87, 33, 60, 14, 71, 65 },
            new[] { 23, 80, 96, 18, 75, 80, 60, 60, 15, 45, 15, 10, 5, 46, 87, 33, 60, 14, 71, 65 })]
        public void ShouldReturnOk(int[] input, int[] output)
        {
            var result = GradingStudents.Solution(input.ToList());
            Assert.Equal(output, result);

        }
    }
}
