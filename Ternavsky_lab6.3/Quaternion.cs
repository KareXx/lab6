using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternavsky_lab6._3
{
    public class Quaternion
    {
        public double W { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Quaternion(double w, double x, double y, double z)
        {
            W = w;
            X = x;
            Y = y;
            Z = z;
        }

        public double Norm()
        {
            return Math.Sqrt(W * W + X * X + Y * Y + Z * Z);
        }

        public Quaternion Conjugate()
        {
            return new Quaternion(W, -X, -Y, -Z);
        }

        public Quaternion Inverse()
        {
            double normSquared = W * W + X * X + Y * Y + Z * Z;
            if (normSquared == 0)
                throw new InvalidOperationException("Кватерніон має нульову норму");

            double inverseFactor = 1 / normSquared;
            return new Quaternion(W * inverseFactor, -X * inverseFactor, -Y * inverseFactor, -Z * inverseFactor);
        }

        public static Quaternion operator +(Quaternion a, Quaternion b)
        {
            return new Quaternion(a.W + b.W, a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Quaternion operator -(Quaternion a, Quaternion b)
        {
            return new Quaternion(a.W - b.W, a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        public static Quaternion operator *(Quaternion a, Quaternion b)
        {
            double w = a.W * b.W - a.X * b.X - a.Y * b.Y - a.Z * b.Z;
            double x = a.W * b.X + a.X * b.W + a.Y * b.Z - a.Z * b.Y;
            double y = a.W * b.Y - a.X * b.Z + a.Y * b.W + a.Z * b.X;
            double z = a.W * b.Z + a.X * b.Y - a.Y * b.X + a.Z * b.W;

            return new Quaternion(w, x, y, z);
        }

        public static bool operator ==(Quaternion a, Quaternion b)
        {
            return a.W == b.W && a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        public static bool operator !=(Quaternion a, Quaternion b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Quaternion))
                return false;

            Quaternion other = (Quaternion)obj;
            return this == other;
        }

        public override int GetHashCode()
        {
            return W.GetHashCode() ^ X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }

        public override string ToString()
        {
            return $"({W}, {X}, {Y}, {Z})";
        }

        public static implicit operator Matrix4x4(Quaternion q)
        {
            double w = q.W, x = q.X, y = q.Y, z = q.Z;
            double xx = x * x, xy = x * y, xz = x * z, xw = x * w;
            double yy = y * y, yz = y * z, yw = y * w;
            double zz = z * z, zw = z * w;

            return new Matrix4x4(
                1 - 2 * (yy + zz), 2 * (xy - zw), 2 * (xz + yw), 0,
                2 * (xy + zw), 1 - 2 * (xx + zz), 2 * (yz - xw), 0,
                2 * (xz - yw), 2 * (yz + xw), 1 - 2 * (xx + yy), 0,
                0, 0, 0, 1
            );
        }

       
    }

}
