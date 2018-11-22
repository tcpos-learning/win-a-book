using FluentAssertions;
using Xunit;

namespace MaxWithoutCompare.Test
{
    public class DummyTest
    {
        [Fact]
        public void friends_should_be_friends()
        {
            "friends".Should().Be("friends");
        }
    }
}