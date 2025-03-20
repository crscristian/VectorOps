using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorOps
{
    public class Vector2D
    {
        // Properties for X and Y coordinates
        public float X { get; }
        public float Y { get; }

        // Constructor to initialize the vector
        public Vector2D(float x, float y)
        {
            X = x;
            Y = y;
        }

        // Static method for adding two vectors
        public static Vector2D Add(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
        }

        // Static method for subtracting two vectors
        public static Vector2D Subtract(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.X - v2.X, v1.Y - v2.Y);
        }

        // Method to calculate the magnitude of the vector
        public float Magnitude()
        {
            return (float)Math.Sqrt(X * X + Y * Y);
        }

        // Static method to calculate the dot product of two vectors
        public static float DotProduct(Vector2D v1, Vector2D v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        // Static method to calculate the cross product of two vectors
        // In 2D, the cross product is a scalar representing the area of the parallelogram formed by the two vectors
        public static float CrossProduct(Vector2D v1, Vector2D v2)
        {
            return v1.X * v2.Y - v1.Y * v2.X;
        }

        // Override the ToString method to display the vector
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
