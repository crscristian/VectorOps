using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace VectorOps
{
    public class OpenGL3DWindow : GameWindow
    {
        private float angle = 0f; // Rotation angle
        private float vectorX;
        private float vectorY;
        private float vectorZ;

        public OpenGL3DWindow(float vectorX, float vectorY, float vectorZ)
            : base(900, 700, GraphicsMode.Default, "3D Graph with Rotating Vector")
        {
            this.vectorX = vectorX;
            this.vectorY = vectorY;
            this.vectorZ = vectorZ;

            VSync = VSyncMode.On; // Enable VSync for smooth animation
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color4.Black); // Background color

            // Enable 3D functionality
            GL.Enable(EnableCap.DepthTest);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(0, 0, Width, Height);

            // Set the projection matrix
            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.DegreesToRadians(45f), Width / (float)Height, 0.1f, 100f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspective);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            // The rotation angle increases continuously
            angle += 50f * (float)e.Time; // 50 degrees per second
            if (angle >= 360f)
                angle -= 360f;
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            // Set the model-view matrix
            Matrix4 modelview = Matrix4.LookAt(
                new Vector3(6, 6, 6), // Camera position
                Vector3.Zero,         // Target point (origin)
                Vector3.UnitY);       // Up vector
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);

            // Draw the grid, axes, and vector
            DrawGrid();
            DrawAxes();
            DrawAxisLabels(); // Call the new method
            HighlightOrigin();
            DrawRotatingVector();

            SwapBuffers();
        }

        private void DrawAxes()
        {
            GL.LineWidth(2.0f); // Thickness of the axes
            GL.Begin(PrimitiveType.Lines);

            // X axis - red (extended to ±10)
            GL.Color3(1f, 0f, 0f);
            GL.Vertex3(-10, 0, 0); // Extend to the left
            GL.Vertex3(10, 0, 0);  // Extend to the right

            // Y axis - green (extended to ±10)
            GL.Color3(0f, 1f, 0f);
            GL.Vertex3(0, -10, 0); // Extend downwards
            GL.Vertex3(0, 10, 0);  // Extend upwards

            // Z axis - blue (extended to ±10)
            GL.Color3(0f, 0f, 1f);
            GL.Vertex3(0, 0, -10); // Extend backwards
            GL.Vertex3(0, 0, 10);  // Extend forwards

            GL.End();
        }

        private void DrawRotatingVector()
        {
            GL.PushMatrix();

            // Apply rotation
            GL.Rotate(angle, 0.0, 1.0, 0.0); // Rotation around the Y axis

            // Set the line width for the vector
            GL.LineWidth(2.5f); // Thicker white vector

            // Draw the vector
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(1f, 1f, 1f); // White color
            GL.Vertex3(0, 0, 0);   // Origin
            GL.Vertex3(vectorX, vectorY, vectorZ); // End point of the vector
            GL.End();

            GL.PopMatrix();
        }

        private void DrawGrid()
        {
            GL.LineWidth(1.0f); // Thickness of the grid lines
            GL.Color3(0.3f, 0.3f, 0.3f); // Darker gray color for the grid

            // Lines on the XY plane
            GL.Begin(PrimitiveType.Lines);
            for (float i = -10; i <= 10; i += 1.0f) // Extend to ±10
            {
                // Lines parallel to the X axis
                GL.Vertex3(-10, i, 0);
                GL.Vertex3(10, i, 0);

                // Lines parallel to the Y axis
                GL.Vertex3(i, -10, 0);
                GL.Vertex3(i, 10, 0);
            }
            GL.End();

            // Lines on the XZ plane
            GL.Begin(PrimitiveType.Lines);
            for (float i = -10; i <= 10; i += 1.0f)
            {
                // Lines parallel to the X axis
                GL.Vertex3(-10, 0, i);
                GL.Vertex3(10, 0, i);

                // Lines parallel to the Z axis
                GL.Vertex3(i, 0, -10);
                GL.Vertex3(i, 0, 10);
            }
            GL.End();

            // Lines on the YZ plane
            GL.Begin(PrimitiveType.Lines);
            for (float i = -10; i <= 10; i += 1.0f)
            {
                // Lines parallel to the Y axis
                GL.Vertex3(0, -10, i);
                GL.Vertex3(0, 10, i);

                // Lines parallel to the Z axis
                GL.Vertex3(0, i, -10);
                GL.Vertex3(0, i, 10);
            }
            GL.End();
        }

        private void DrawAxisTicks()
        {
            GL.LineWidth(2.0f); // Thickness of the tick lines
            GL.Color3(1.0f, 1.0f, 1.0f); // White color for ticks

            GL.Begin(PrimitiveType.Lines);

            // Ticks on the X axis
            for (float i = -5; i <= 5; i += 1.0f)
            {
                GL.Vertex3(i, -0.1f, 0); // Tick below
                GL.Vertex3(i, 0.1f, 0);  // Tick above
            }

            // Ticks on the Y axis
            for (float i = -5; i <= 5; i += 1.0f)
            {
                GL.Vertex3(-0.1f, i, 0); // Tick left
                GL.Vertex3(0.1f, i, 0);  // Tick right
            }

            // Ticks on the Z axis
            for (float i = -5; i <= 5; i += 1.0f)
            {
                GL.Vertex3(0, -0.1f, i); // Tick below
                GL.Vertex3(0, 0.1f, i);  // Tick above
            }

            GL.End();
        }

        private void HighlightOrigin()
        {
            GL.PointSize(5.0f); // Size of the point
            GL.Begin(PrimitiveType.Points);
            GL.Color3(1f, 1f, 0f); // Yellow color
            GL.Vertex3(0, 0, 0);   // Point at the origin
            GL.End();
        }

        private void DrawTextOpenGL(string text, float x, float y, float z)
        {
            // Set the position of the text in 3D space
            GL.RasterPos3(x, y, z);

            foreach (char c in text)
            {
                // Render each character using FreeType or a custom text method
                GL.Bitmap(0, 0, 0, 0, 8, 0, Encoding.ASCII.GetBytes(new[] { c }));
            }
        }

        private void DrawAxisLabels()
        {
            GL.LineWidth(2.0f); // Thickness of the lines for ticks
            GL.Color3(1.0f, 1.0f, 1.0f); // White color for ticks and labels

            GL.Begin(PrimitiveType.Lines);

            // Ticks and labels on the X axis
            for (int i = -10; i <= 10; i++)
            {
                GL.Vertex3(i, -0.1f, 0); // Tick below
                GL.Vertex3(i, 0.1f, 0);  // Tick above

                // Numeric label for the X axis
                if (i != 0) // Skip the label at the origin
                    DrawTextOpenGL(i.ToString(), i, -0.3f, 0); // Label slightly below the tick
            }

            // Ticks and labels on the Y axis
            for (int i = -10; i <= 10; i++)
            {
                GL.Vertex3(-0.1f, i, 0); // Tick left
                GL.Vertex3(0.1f, i, 0);  // Tick right

                // Numeric label for the Y axis
                if (i != 0) // Skip the label at the origin
                    DrawTextOpenGL(i.ToString(), -0.3f, i, 0); // Label slightly to the side
            }

            // Ticks and labels on the Z axis
            for (int i = -10; i <= 10; i++)
            {
                GL.Vertex3(0, -0.1f, i); // Tick below
                GL.Vertex3(0, 0.1f, i);  // Tick above

                // Numeric label for the Z axis
                if (i != 0) // Skip the label at the origin
                    DrawTextOpenGL(i.ToString(), 0, -0.3f, i); // Label slightly behind
            }

            GL.End();
        }
    }
}
