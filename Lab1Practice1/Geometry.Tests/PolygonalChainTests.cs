using FluentAssertions;
using Newtonsoft.Json.Linq;

namespace Geometry.Tests
{
    public class PolygonalChainTests
    {
        [Fact]
        public void Length_should_return_proper_results()
        {
            var TestPolygonalChain = new PolygonalChain(new Point(1, 1), new Point(4, 5));

        }
    }
}