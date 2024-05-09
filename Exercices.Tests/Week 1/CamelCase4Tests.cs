using Exercices.Week_1;
using Xunit;

namespace Exercices.Tests.Week_1
{
    public class CamelCase4Tests
    {
        [Theory]
        [InlineData("S;M;plasticCup()", "plastic cup")]
        [InlineData("C;V;mobile phone", "mobilePhone")]
        [InlineData("C;C;coffee machine", "CoffeeMachine")]
        [InlineData("S;C;LargeSoftwareBook", "large software book")]
        [InlineData("C;M;white sheet of paper", "whiteSheetOfPaper()")]
        [InlineData("S;V;pictureFrame", "picture frame")]
        [InlineData("S;V;iPad", "i pad")]
        [InlineData("C;M;mouse pad", "mousePad()")]
        [InlineData("C;C;code swarm", "CodeSwarm")]
        [InlineData("S;C;OrangeHighlighter", "orange highlighter")]
        [InlineData("C;V;can of coke", "canOfCoke")]
        [InlineData("S;M;sweatTea()", "sweat tea")]
        [InlineData("S;V;epsonPrinter", "epson printer")]
        [InlineData("C;C;mirror", "Mirror")]
        public void ShouldReturnOk(string input, string output)
        {

            var result = CamelCase4.Solution(input);
            Assert.Equal(output, result);

        }

    }
}
