using FluentAssertions;

namespace Geometry.Tests
{
    public class PointTests
    {
        [Fact]
        public void Move_should_return_proper_results()
        {
            var TestPoint = new Point(5, 5);
            TestPoint.Move(-5, -4);

            TestPoint.X.Should().Be(0);
            TestPoint.Y.Should().Be(1);
        }
        [Fact]
        public void Distance_should_return_proper_results()
        {
            var TestPoint = new Point(1, 2);

            TestPoint.Distance().Should().Be(2.23606797749979);
        }

    }
}