using Exercices.Week_4;
using Xunit;

namespace Exercices.Tests.Week_4
{
    public class SeparatetheNumbersTests
    {
        [Theory]
        [InlineData("12345", "YES 1")]
        [InlineData("7", "NO")]
        [InlineData("1234", "YES 1")]
        [InlineData("91011", "YES 9")]
        [InlineData("99100", "YES 99")]
        [InlineData("101103", "NO")]
        [InlineData("010203", "NO")]
        [InlineData("13", "NO")]
        [InlineData("1", "NO")]
        public void ShouldReurnOk(string input, string output)
        {
            var result = SeparatetheNumbers.Solution(input);
            Assert.Equal(output, result);

        }
    }
}
