using Exercices.Week_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Exercices.Tests
{
    public class PlusMinusTests
    {
        [Fact]
        public void ShouldReturnOk()
        {

            var data = new List<int>() { 1, 1, -1, -1, 0 };
            var result = PlusMinus.Solution(data);
            var proportion = new double[] { 0.400000, 0.400000, 0.200000 };
            Assert.Equal(proportion, result);

        }
    }
}
