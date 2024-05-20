using Exercices.Week_3;
using Xunit;

namespace Exercices.Tests.Week_3
{
    public class DrawingBookTests
    {
        [Theory]
        [InlineData(6, 2, 1)]
        [InlineData(5, 4, 0)]
        public void ShouldReturnOk(int n, int p, int output)
        {
            var result = DrawingBook.Solution(n, p);
            Assert.Equal(output, result);

        }
    }
}
