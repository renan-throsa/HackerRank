using Exercices.Week_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Exercices.Tests.Week_4
{
    public class MinimumAbsoluteDifferenceTests
    {
        [Theory]
        [InlineData(new[] { 3, -7, 0 }, 3)]
        [InlineData(new[] { 1, -3, 71, 68, 17 }, 3)]
        [InlineData(new[] { -59, -36, -13, 1, -53, -92, -2, -96, -54, 75 }, 1)]
        public void ShouldReurnOk(int[] input, int output)
        {
            var result = MinimumAbsoluteDifference.Solution(input.ToList());
            Assert.Equal(output, result);

        }
    }
}
