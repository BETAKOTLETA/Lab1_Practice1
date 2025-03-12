namespace Geometry;

public class Segment
{
    private Point _start;
    private Point _end;

    public Point Start => _start;
    public Point End => _end;

    public Segment(Point start, Point end)
    {
        _start = start;
        _end = end;
    }

    public virtual double Length =>
        Math.Sqrt(Math.Pow(_start.X - _end.X, 2) + Math.Pow(_start.Y - _end.Y, 2));
}