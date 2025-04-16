
using PointLibrary;
var p1 = new Point3D(1, 2, 3);
var p2 = new ColoredPoint3D(4, 5, 6, "Red");

Console.WriteLine($"Distance to origin: {p1.DistanceToOrigin()}");
Console.WriteLine($"Color of p2: {p2.Color}");
