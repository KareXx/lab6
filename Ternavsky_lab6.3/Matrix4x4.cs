using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternavsky_lab6._3
{
    public class Matrix4x4
    {
        public double M11 { get; set; }
        public double M12 { get; set; }
        public double M13 { get; set; }
        public double M14 { get; set; }
        public double M21 { get; set; }
        public double M22 { get; set; }
        public double M23 { get; set; }
        public double M24 { get; set; }
        public double M31 { get; set; }
        public double M32 { get; set; }
        public double M33 { get; set; }
        public double M34 { get; set; }
        public double M41 { get; set; }
        public double M42 { get; set; }
        public double M43 { get; set; }
        public double M44 { get; set; }

        public Matrix4x4(
            double m11, double m12, double m13, double m14,
            double m21, double m22, double m23, double m24,
            double m31, double m32, double m33, double m34,
            double m41, double m42, double m43, double m44)
        {
            M11 = m11; M12 = m12; M13 = m13; M14 = m14;
            M21 = m21; M22 = m22; M23 = m23; M24 = m24;
            M31 = m31; M32 = m32; M33 = m33; M34 = m34;
            M41 = m41; M42 = m42; M43 = m43; M44 = m44;
        }

        public override string ToString()
        {
            return $"{M11} {M12} {M13} {M14}\n" +
                   $"{M21} {M22} {M23} {M24}\n" +
                   $"{M31} {M32} {M33} {M34}\n" +
                   $"{M41} {M42} {M43} {M44}";
        }

        public static Quaternion ToQuaternion(Matrix4x4 matrix)
        {
            double trace = matrix.M11 + matrix.M22 + matrix.M33;

            if (trace > 0)
            {
                double s = 0.5 / Math.Sqrt(trace + 1.0);
                double w = 0.25 / s;
                double x = (matrix.M32 - matrix.M23) * s;
                double y = (matrix.M13 - matrix.M31) * s;
                double z = (matrix.M21 - matrix.M12) * s;
                return new Quaternion(w, x, y, z);
            }
            else if (matrix.M11 > matrix.M22 && matrix.M11 > matrix.M33)
            {
                double s = 2.0 * Math.Sqrt(1.0 + matrix.M11 - matrix.M22 - matrix.M33);
                double w = (matrix.M32 - matrix.M23) / s;
                double x = 0.25 * s;
                double y = (matrix.M12 + matrix.M21) / s;
                double z = (matrix.M13 + matrix.M31) / s;
                return new Quaternion(w, x, y, z);
            }
            else if (matrix.M22 > matrix.M33)
            {
                double s = 2.0 * Math.Sqrt(1.0 + matrix.M22 - matrix.M11 - matrix.M33);
                double w = (matrix.M13 - matrix.M31) / s;
                double x = (matrix.M12 + matrix.M21) / s;
                double y = 0.25 * s;
                double z = (matrix.M23 + matrix.M32) / s;
                return new Quaternion(w, x, y, z);
            }
            else
            {
                double s = 2.0 * Math.Sqrt(1.0 + matrix.M33 - matrix.M11 - matrix.M22);
                double w = (matrix.M21 - matrix.M12) / s;
                double x = (matrix.M13 + matrix.M31) / s;
                double y = (matrix.M23 + matrix.M32) / s;
                double z = 0.25 * s;
                return new Quaternion(w, x, y, z);
            }
        }
    }
}
