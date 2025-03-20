using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorOps
{
    public class Vector3D
    {
        // Properties for X, Y, and Z coordinates
        public float X { get; }
        public float Y { get; }
        public float Z { get; }

        // Constructor to initialize the vector
        public Vector3D(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Static method for adding two vectors
        public static Vector3D Add(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        // Static method for subtracting two vectors
        public static Vector3D Subtract(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        // Method to calculate the magnitude of the vector
        public float Magnitude()
        {
            return (float)Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        // Static method to calculate the dot product of two vectors
        public static float DotProduct(Vector3D v1, Vector3D v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        // Static method to calculate the cross product of two vectors
        public static Vector3D CrossProduct(Vector3D v1, Vector3D v2)
        {
            float x = v1.Y * v2.Z - v1.Z * v2.Y;
            float y = v1.Z * v2.X - v1.X * v2.Z;
            float z = v1.X * v2.Y - v1.Y * v2.X;
            return new Vector3D(x, y, z);
        }

        // Override the ToString method to display the vector
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
