using FluentAssertions;
using Xunit;

namespace MaxWithoutCompare.Test
{
    public class MaxCalculatorTest
    {
        private readonly Calculator _sut;

        public MaxCalculatorTest()
        {
            _sut = new Calculator();            
        }
        
        [Theory]
        [InlineData(127, 212, 212)]
        [InlineData(25, 11, 25)]
        [InlineData(100, 100, 100)]
        [InlineData(0, 100, 100)]
        [InlineData(100, 0, 100)]
        public void should_identify_the_biggest_between_two_numbers(int first, int second, int expected)
        {
            var result = _sut.Max(first, second);

            result.Should().Be(expected);
        }
        
        [Theory]
        [InlineData(1, -2, 1)]
        [InlineData(-10, -2, -2)]
        [InlineData(-15, 19, 19)]
        [InlineData(-15, 0, 0)]
        [InlineData(0, -15, 0)]
        public void should_identity_the_biggest_between_two_numbers_also_with_negative_numbers(int first, int second, int expected)
        {
            var result = _sut.Max(first, second);

            result.Should().Be(expected);
        }
    }
}