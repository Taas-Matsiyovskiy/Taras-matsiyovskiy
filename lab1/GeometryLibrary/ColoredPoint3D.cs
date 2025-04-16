using System.Drawing; // або використати string для кольору

namespace PointLibrary
{
    public class ColoredPoint3D : Point3D
    {
        public string Color { get; }

        public ColoredPoint3D(double x, double y, double z, string color)
            : base(x, y, z)
        {
            Color = color;
        }

        public override string ToString()
        {
            return base.ToString() + $", Color: {Color}";
        }
    }
}
