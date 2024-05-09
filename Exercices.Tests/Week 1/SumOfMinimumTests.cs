using Exercices.Week_1;
using Xunit;

namespace Exercices.Tests
{
    public class SumOfMinimumTests
    {
        [Fact]
        public void ShouldWorkWithPositives()
        {
            var data = new int[][] {
                    new int[] { 1, 2, 3 },
                    new int[] { 4, 5, 6 },
                    new int[] { 7, 8, 9 }
            };


            var result = SumOfMinimum.Solution(data);
            Assert.Equal(12, result);
        }

        [Fact]
        public void ShouldWorkWithMixNumbers()
        {
            var data = new int[][] {
                    new int[] { 1, 2, -3 },
                    new int[] { -4, 5, 6 },
                    new int[] {  7, 8, 9 }
            };


            var result = SumOfMinimum.Solution(data);
            Assert.Equal(0, result);
        }

        [Fact]
        public void ShouldWorkWithNegatives()
        {
            var data = new int[][] {
                    new int[] {-202385, -189170, -141342, -186739},
                    new int[] {-181903, -169719, -128511},
                    new int[] { -185733, -153421, -139255, -92688 }
            };


            var result = SumOfMinimum.Solution(data);
            Assert.Equal(-570021, result);
        }

        [Fact]
        public void ShouldWorkWithSigle()
        {
            var data = new int[][] { new int[] { 1 } };


            var result = SumOfMinimum.Solution(data);
            Assert.Equal(1, result);
        }
    }
}