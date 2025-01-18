using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorOps
{
    public class Vector2D
    {
        // Proprietăți pentru coordonatele X și Y
        public float X { get; }
        public float Y { get; }

        // Constructor pentru inițializarea vectorului
        public Vector2D(float x, float y)
        {
            X = x;
            Y = y;
        }

        // Metodă statică pentru adunarea a doi vectori
        public static Vector2D Adunare(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
        }

        // Metodă statică pentru scăderea a doi vectori
        public static Vector2D Scadere(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.X - v2.X, v1.Y - v2.Y);
        }

        // Metodă pentru calculul modulului vectorului
        public float Modul()
        {
            return (float)Math.Sqrt(X * X + Y * Y);
        }

        // Metodă statică pentru calculul produsului scalar a doi vectori
        public static float ProdusScalar(Vector2D v1, Vector2D v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        // Metodă statică pentru calculul produsului vectorial a doi vectori
        // În 2D, produsul vectorial este un scalar care reprezintă aria paralelogramului format de cei doi vectori
        public static float ProdusVectorial(Vector2D v1, Vector2D v2)
        {
            return v1.X * v2.Y - v1.Y * v2.X;
        }

        // Suprascrierea metodei ToString pentru afișarea vectorului
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
