using Exercices.Week_3;
using Xunit;

namespace Exercices.Tests.Week_3
{
    public class XORStrings3Tests
    {

        [Theory]
        [InlineData("10101", "00101", "10000")]
        [InlineData("01010", "10101", "11111")]
        [InlineData("1", "0", "1")]
        [InlineData("1101111011000001001001010010001001111110001110100100100100001101101010101001110010000101011110111000",
            "1010001101111011110100010101111110101101100000001001110000110110001100011110100100001010001101010011",
            "0111110110111010111101000111110111010011101110101101010100111011100110110111010110001111010011101011")]
        public void ShouldReturnOk(string s, string t,string output)
        {
            var result = XORStrings3.Solution(s, t);
            Assert.Equal(output, result);

        }

    }
}
