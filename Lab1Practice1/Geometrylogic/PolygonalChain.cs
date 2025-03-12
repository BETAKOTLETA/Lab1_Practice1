namespace Geometry;

public class PolygonalChain : Segment, IMoveable
{
    private List<Point> _midpoints = new List<Point>();

    public PolygonalChain(Point start, Point end) : base(start, end) { }

    public void AddMidpoint(Point midpoint) => _midpoints.Add(midpoint);

    public List<Point> Midpoints() => _midpoints;

    public override double Length
    {
        get
        {
            var allPoints = new List<Point>();
            allPoints.Add(Start);
            allPoints.AddRange(_midpoints);
            allPoints.Add(End);

            var totalLength = 0.0;

            for (var i = 0; i < allPoints.Count - 1; i++)
            {
                var start = allPoints[i];
                var end = allPoints[i + 1];

                totalLength += new Segment(start, end).Length;
            }

            return totalLength;
        }
    }

    public void Move(double x, double y)
    {
        Start.Move(x, y);
        End.Move(x, y);

        foreach (var midpoint in _midpoints)
            midpoint.Move(x, y);
    }

    public override string ToString()
    {
        var result = $"({Start.X},{Start.Y})";

        foreach (var midpoint in _midpoints)
            result += $",({midpoint.X},{midpoint.Y})";

        result += $",({End.X},{End.Y})";

        return result;
    }
}