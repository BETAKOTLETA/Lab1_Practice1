using FluentAssertions;
using Newtonsoft.Json.Linq;

namespace Geometry.Tests
{
    public class PolygonalChainTests
    {
        [Fact]
        public void Polyponal_can_be_created()
        {
            var Testpolygonalchain = new PolygonalChain(new Point(1, 1), new Point(4, 5));

            Testpolygonalchain.Should().BeOfType<PolygonalChain>();

            Testpolygonalchain.Start.Should().BeEquivalentTo(new Point(1, 1));
            Testpolygonalchain.Start.Should().BeOfType<Point>();

            Testpolygonalchain.End.Should().BeEquivalentTo(new Point(4, 5));
            Testpolygonalchain.End.Should().BeOfType<Point>();
        }

        [Fact]
        public void Midpoint_can_be_created()
        {
            var Testopolygonalchain = new PolygonalChain(new Point(1, 1), new Point(4, 5));

            Testopolygonalchain.AddMidpoint(new Point(2, 2));
            Testopolygonalchain.AddMidpoint(new Point(3, 3));

            Testopolygonalchain.Midpoints().Should().BeEquivalentTo(new List<Point> { new Point(2, 2), new Point(3, 3) });
        }
        [Fact]
        public void Length_should_return_proper_results()
        {
            var Testpolygonalchain = new PolygonalChain(new Point(1, 1), new Point(4, 5));
            Testpolygonalchain.Length.Should().Be(5);
        }
        [Fact] 
        public void Length_should_return_proper_results_with_midpoints()
        {
            var Testpolygonalchain = new PolygonalChain(new Point(1, 1), new Point(4, 5));
            Testpolygonalchain.AddMidpoint(new Point(2, 2));
            Testpolygonalchain.AddMidpoint(new Point(3, 3));
            Testpolygonalchain.Length.Should().Be(5.06449510224598);
        }
        [Fact]
        public void Move_should_return_proper_results_with_midpoints()
        {
            var Testpolygonalchain = new PolygonalChain(new Point(1, 1), new Point(4, 5));
            Testpolygonalchain.AddMidpoint(new Point(2, 2));
            Testpolygonalchain.AddMidpoint(new Point(3, 3));
            Testpolygonalchain.Move(-1, -1);
            Testpolygonalchain.ToString().Should().Be("(0,0),(1,1),(2,2),(3,4)");
        }
        [Fact]
        public void Move_should_return_proper_results()
        {
            var testpolygonalchain = new PolygonalChain(new Point(1, 1), new Point(4, 5));
            testpolygonalchain.Move(-1, -1);
            testpolygonalchain.ToString().Should().Be("(0,0),(3,4)");
        }
        [Fact]
        public void ToString_should_return_proper_results()
        {
            var testopolygonalchain = new PolygonalChain(new Point(1, 1), new Point(4, 5));
            testopolygonalchain.ToString().Should().Be("(1,1),(4,5)");
        }
    }
}