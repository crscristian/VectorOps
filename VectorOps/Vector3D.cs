using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorOps
{
    public class Vector3D
    {
        // Proprietăți pentru coordonatele X, Y și Z
        public float X { get; }
        public float Y { get; }
        public float Z { get; }

        // Constructor pentru inițializarea vectorului
        public Vector3D(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Metodă statică pentru adunarea a doi vectori
        public static Vector3D Adunare(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        // Metodă statică pentru scăderea a doi vectori
        public static Vector3D Scadere(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        // Metodă pentru calculul modulului vectorului
        public float Modul()
        {
            return (float)Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        // Metodă statică pentru calculul produsului scalar a doi vectori
        public static float ProdusScalar(Vector3D v1, Vector3D v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        // Metodă statică pentru calculul produsului vectorial a doi vectori
        public static Vector3D ProdusVectorial(Vector3D v1, Vector3D v2)
        {
            float x = v1.Y * v2.Z - v1.Z * v2.Y;
            float y = v1.Z * v2.X - v1.X * v2.Z;
            float z = v1.X * v2.Y - v1.Y * v2.X;
            return new Vector3D(x, y, z);
        }

        // Suprascrierea metodei ToString pentru afișarea vectorului
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
