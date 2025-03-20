using System;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace VectorOps
{
    public class OpenGL2DWindow : GameWindow
    {
        private float angle = 0f; // Rotation angle

        public OpenGL2DWindow()
            : base(800, 600, GraphicsMode.Default, "2D Graph with Rotating Vector")
        {
            VSync = VSyncMode.On; // Enable VSync for smooth animation
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color4.Black); // Background color
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(0, 0, Width, Height);

            // Configure an orthographic projection for the 2D graph
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-10, 10, -10, 10, -1, 1); // Orthographic projection from -10 to 10 on X and Y
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

            GL.Clear(ClearBufferMask.ColorBufferBit);

            // Draw the grid, axes, and rotating vector
            DrawGrid();
            DrawAxes();
            DrawRotatingVector();

            SwapBuffers();
        }

        private void DrawAxes()
        {
            GL.LineWidth(2.0f); // Thickness of the axes
            GL.Begin(PrimitiveType.Lines);

            // X axis - red
            GL.Color3(1f, 0f, 0f);
            GL.Vertex2(-10, 0);
            GL.Vertex2(10, 0);

            // Y axis - green
            GL.Color3(0f, 1f, 0f);
            GL.Vertex2(0, -10);
            GL.Vertex2(0, 10);

            GL.End();
        }

        private void DrawGrid()
        {
            GL.LineWidth(1.0f); // Thickness of the grid lines
            GL.Color3(0.3f, 0.3f, 0.3f); // Darker gray color for the grid

            GL.Begin(PrimitiveType.Lines);
            for (float i = -10; i <= 10; i += 1.0f)
            {
                // Lines parallel to the X axis
                GL.Vertex2(-10, i);
                GL.Vertex2(10, i);

                // Lines parallel to the Y axis
                GL.Vertex2(i, -10);
                GL.Vertex2(i, 10);
            }
            GL.End();
        }

        private void DrawRotatingVector()
        {
            GL.PushMatrix();

            // Calculate the rotated coordinates in the XY plane
            double radians = MathHelper.DegreesToRadians(angle);
            float cosAngle = (float)Math.Cos(radians);
            float sinAngle = (float)Math.Sin(radians);

            float initialX = 5.0f; // Length of the vector
            float initialY = 0.0f; // Y component of the vector

            float rotatedX = initialX * cosAngle - initialY * sinAngle;
            float rotatedY = initialX * sinAngle + initialY * cosAngle;

            // Draw the rotated vector
            GL.LineWidth(2.5f);
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(1f, 1f, 1f); // White color
            GL.Vertex2(0, 0);           // Origin
            GL.Vertex2(rotatedX, rotatedY); // End point of the rotated vector
            GL.End();

            GL.PopMatrix();
        }
    }
}
