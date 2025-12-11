using Serensia.Algorithms;
using Serensia.Abstractions;
using Xunit;

namespace Serensia.Tests
{

    public class DifferenceCalculatorTests
    {
        private readonly IDifferenceCalculator _calculator = new DifferenceCalculator();

        [Theory]
        [InlineData("gros", "gros", 0)]
        [InlineData("gros", "gras", 1)]
        [InlineData("abcd", "wxyz", 4)]
        public void GetDifferenceScore_ReturnsExpectedValues(string a, string b, int expected)
        {
            int score = _calculator.GetDifferenceScore(a.AsSpan(), b.AsSpan());
            Assert.Equal(expected, score);
        }

        [Fact]
        public void ThrowsIfLengthsDiffer()
        {
            Assert.Throws<ArgumentException>(() =>
                _calculator.GetDifferenceScore("abc".AsSpan(), "abcd".AsSpan()));
        }
    }
}