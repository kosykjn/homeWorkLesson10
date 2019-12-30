namespace homeWorkLesson10_5
{
    class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Point3D operator +(Point3D p1, Point3D p2)
        {
            return new Point3D(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
        }

        public static Point3D operator -(Point3D p1, Point3D p2)
        {
            return new Point3D(p1.X - p2.X, p1.Y - p2.Y, p1.Z - p2.Z);
        }

        public static Point3D operator *(Point3D p1, Point3D p2)
        {
            return new Point3D(p1.X * p2.X, p1.Y * p2.Y, p1.Z * p2.Z);
        }

        public static Point3D operator /(Point3D p1, Point3D p2)
        {
            return new Point3D(p1.X / p2.X, p1.Y / p2.Y, p1.Z / p2.Z);
        }

        public static Point3D operator ++(Point3D p)
        {
            return new Point3D(p.X + 1.0, p.Y + 1.0, p.Z + 1.0);
        }

        public static Point3D operator --(Point3D p)
        {
            return new Point3D(p.X - 1.0, p.Y - 1.0, p.Z - 1.0);
        }

        public static bool operator ==(Point3D p1, Point3D p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !p1.Equals(p2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Point3D)
            {
                if (((Point3D)obj).X == this.X && ((Point3D)obj).Y == this.Y)
                    return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}]", this.X, this.Y, this.Z);
        }
    }
}
