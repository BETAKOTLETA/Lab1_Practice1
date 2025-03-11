using FluentAssertions;

namespace Geometry.Tests
{
    public class SegmentTests
    {
        [Fact]
        public void Length_should_return_proper_results()
        {
            var TestSegment = new Segment(new Point(1, 1), new Point(4, 5));

            TestSegment.Length.Should().Be(5); // I am not sure about this value
        }


    }
}