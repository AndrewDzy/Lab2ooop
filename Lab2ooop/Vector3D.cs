using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2ooop
{
    class Vector3D
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }
        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static Vector3D operator +(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }
        public static Vector3D operator -(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }
        public static double DotProduct(Vector3D v1, Vector3D v2)
        {
            return (v1.X * v2.X) + (v1.Y * v2.Y) + (v1.Z * v2.Z);
        }
        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
        public static double CosineOfAngle(Vector3D v1, Vector3D v2)
        {
            double dotProduct = DotProduct(v1, v2);
            double lengthV1 = v1.Length();
            double lengthV2 = v2.Length();

            return dotProduct / (lengthV1 * lengthV2);
        }
    }
}
