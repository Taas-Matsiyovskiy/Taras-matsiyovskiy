namespace PointLibrary
{
    public class Point3D
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double DistanceToOrigin()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public double DistanceTo(Point3D other)
        {
            return Math.Sqrt(
                Math.Pow(X - other.X, 2) +
                Math.Pow(Y - other.Y, 2) +
                Math.Pow(Z - other.Z, 2)
            );
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
