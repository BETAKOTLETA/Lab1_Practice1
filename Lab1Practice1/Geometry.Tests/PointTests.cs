using FluentAssertions;

namespace Geometry.Tests
{
    public class PointTests
    {
        [Fact]
        public void Point_can_be_created()
        {
            var Testpoint = new Point();

            Testpoint.Should().BeOfType<Point>();

            Testpoint.X.Should().Be(0);
            Testpoint.Y.Should().Be(0);

            
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(5, 5)]
        [InlineData(-3, -3)]

        public void Point_can_be_created_with_one_input(double x, double expected)
        {
            var Testpoint = new Point(x);

            Testpoint.Should().BeOfType<Point>();

            Testpoint.X.Should().Be(expected);
            Testpoint.Y.Should().Be(expected);


        }
        [Fact]
        public void Point_can_be_created_with_two_inputs()
        {
            var Testpoint = new Point(1, 2);

            Testpoint.Should().BeOfType<Point>();

            Testpoint.X.Should().Be(1);
            Testpoint.Y.Should().Be(2);
        }
        [Fact]
        public void Move_should_return_proper_results()
        {
            var Testpoint = new Point(5, 5);

            Testpoint.Move(-5, -4);


            Testpoint.X.Should().Be(0);
            Testpoint.Y.Should().Be(1);
        }
        [Fact]
        public void Distance_should_return_proper_results()
        {
            var Testpoint = new Point(3, 4);
            
            Testpoint.Distance().Should().Be(5);
        }

    }
}