using Automotive;
using Geometry;
using System.Runtime.ConstrainedExecution;


Console.WriteLine("Hello, World!");

//var TestPolygonalChain = new PolygonalChain(new Point(1, 1), new Point(4, 5));
//TestPolygonalChain.AddMidpoint(new Point(-10, -10));
//Console.WriteLine(TestPolygonalChain.Length);

var Testcar = new Car("Toyota", 200, 6);

Console.WriteLine(Testcar.CurrentFuelLevel);

Testcar.Drive(100);

Console.WriteLine(Testcar.CurrentFuelLevel);