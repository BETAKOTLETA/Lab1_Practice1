using Geometry;

namespace Geometry;

public class Point : IMoveable
{
    private double _x;
    private double _y;

    public double X => _x;
    public double Y => _y;

    public Point() => _x = _y = 0;

    public Point(double a) => _x = _y = a;

    public Point(double x, double y) => (_x, _y) = (x, y);

    public void Move(double x, double y)
    {
        _x += x;
        _y += y;
    }

    public virtual double Distance() => Math.Sqrt(X * X + Y * Y);
}