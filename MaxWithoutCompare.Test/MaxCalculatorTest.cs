using FluentAssertions;
using Xunit;

namespace MaxWithoutCompare.Test
{
    public class MaxCalculatorTest
    {
        [Theory]
        [InlineData(127, 212, 212)]
        [InlineData(25, 11, 25)]
        [InlineData(1, -2, 1)]
        [InlineData(-10, -2, -2)]
        [InlineData(100, 100, 100)]
        [InlineData(-15, 19, 19)]
        public void should_(int first, int second, int expected)
        {
            var sut = new MaxCalculator();

            var result = sut.Calculate(first, second);

            result.Should().Be(expected);
        }
    }
}