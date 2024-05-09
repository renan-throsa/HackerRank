using Exercices.Week_1;
using Xunit;

namespace Exercices.Tests
{
    public class TimeConversionTests
    {
        [Theory]
        [InlineData("07:05:45PM", "19:05:45")]
        [InlineData("12:01:00PM", "12:01:00")]
        [InlineData("12:01:00AM", "00:01:00")]
        public void ShouldReturnOk(string date,string expected)
        {
            
            var result = TimeConversion.Solution(date);
            Assert.Equal(expected, result);

        }
    }
}
