using Exercices.Week_2;
using System.Drawing;
using Xunit;
using static System.Net.Mime.MediaTypeNames;

namespace Exercices.Tests.Week_2
{
    public class PangramsTests
    {
        [Theory]
        [InlineData("We promptly judged antique ivory buckles for the prize", "not pangram")]
        [InlineData("We promptly judged antique ivory buckles for the next prize", "pangram")]
        public void ShouldReturnOk(string input, string output)
        {
            var result = Pangrams.Solution(input);
            Assert.Equal(output, result);

        }
    }
}
