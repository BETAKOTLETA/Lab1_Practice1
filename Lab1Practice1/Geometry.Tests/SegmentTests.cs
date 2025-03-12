using FluentAssertions;

namespace Geometry.Tests
{
    public class SegmentTests
    {


        [Fact]
        public void Length_should_return_proper_results()
        {
            var TestSegment = new Segment(new Point(1, 1), new Point(4, 5));

            TestSegment.Length.Should().Be(5); 
        }

        [Fact]
        public void Segment_can_be_created()
        {
            var TestSegment = new Segment(new Point(1, 1), new Point(4, 5));

            TestSegment.Should().BeOfType<Segment>();



            TestSegment.Start.Should().BeEquivalentTo(new Point(1, 1));
            TestSegment.Start.Should().BeOfType<Point>();
            TestSegment.End.Should().BeEquivalentTo(new Point(4, 5));
            TestSegment.End.Should().BeOfType<Point>();
        }
    }
}