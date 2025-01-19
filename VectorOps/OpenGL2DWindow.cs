using System;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace VectorOps
{
    public class OpenGL2DWindow : GameWindow
    {
        private float angle = 0f; // Unghiul de rotație

        public OpenGL2DWindow()
            : base(800, 600, GraphicsMode.Default, "Grafic 2D cu Vector Rotit")
        {
            VSync = VSyncMode.On; // Activăm VSync pentru animație fluidă
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color4.Black); // Fundalul graficului
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(0, 0, Width, Height);

            // Configurăm o proiecție ortografică pentru graficul 2D
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-10, 10, -10, 10, -1, 1); // Proiecție ortografică de la -10 la 10 pe X și Y
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            // Rotația crește continuu
            angle += 50f * (float)e.Time; // 50 de grade pe secundă
            if (angle >= 360f)
                angle -= 360f;
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit);

            // Desenăm grila, axele și vectorul rotit
            DrawGrid();
            DrawAxes();
            DrawRotatingVector();

            SwapBuffers();
        }

        private void DrawAxes()
        {
            GL.LineWidth(2.0f); // Grosimea axelor
            GL.Begin(PrimitiveType.Lines);

            // Axa X - roșu
            GL.Color3(1f, 0f, 0f);
            GL.Vertex2(-10, 0);
            GL.Vertex2(10, 0);

            // Axa Y - verde
            GL.Color3(0f, 1f, 0f);
            GL.Vertex2(0, -10);
            GL.Vertex2(0, 10);

            GL.End();
        }

        private void DrawGrid()
        {
            GL.LineWidth(1.0f); // Grosimea liniilor pentru grilă
            GL.Color3(0.3f, 0.3f, 0.3f); // Culoare gri mai închis pentru grilă

            GL.Begin(PrimitiveType.Lines);
            for (float i = -10; i <= 10; i += 1.0f)
            {
                // Linii paralele cu axa X
                GL.Vertex2(-10, i);
                GL.Vertex2(10, i);

                // Linii paralele cu axa Y
                GL.Vertex2(i, -10);
                GL.Vertex2(i, 10);
            }
            GL.End();
        }

        private void DrawRotatingVector()
        {
            GL.PushMatrix();

            // Calculăm coordonatele rotite în planul XY
            double radians = MathHelper.DegreesToRadians(angle);
            float cosAngle = (float)Math.Cos(radians);
            float sinAngle = (float)Math.Sin(radians);

            float initialX = 5.0f; // Lungimea vectorului
            float initialY = 0.0f; // Componenta Y a vectorului

            float rotatedX = initialX * cosAngle - initialY * sinAngle;
            float rotatedY = initialX * sinAngle + initialY * cosAngle;

            // Desenăm vectorul rotit
            GL.LineWidth(2.5f);
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(1f, 1f, 1f); // Culoare albă
            GL.Vertex2(0, 0);           // Originea
            GL.Vertex2(rotatedX, rotatedY); // Punctul final al vectorului rotit
            GL.End();

            GL.PopMatrix();
        }
    }
}
