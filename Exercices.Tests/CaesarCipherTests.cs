using Exercices.Week_4;
using Xunit;

namespace Exercices.Tests
{
    public class CaesarCipherTests
    {
        [Theory]
        [InlineData("middle-Outz",2, "okffng-Qwvb")]
        [InlineData("Always-Look-on-the-Bright-Side-of-Life", 5, "Fqbfdx-Qttp-ts-ymj-Gwnlmy-Xnij-tk-Qnkj")]
        [InlineData("Ciphering.", 26, "Ciphering.")]
        [InlineData("www.abc.xy", 87, "fff.jkl.gh")]
        [InlineData("159357lcfd", 98, "159357fwzx")]
        public void ShouldReurnOk(string input,int key, string output)
        {
            var result = CaesarCipher.Solution(input,key);
            Assert.Equal(output, result);

        }
    }
}
