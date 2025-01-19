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
        private float angle = 0f; // Unghiul de rotație
        private float vectorX;
        private float vectorY;
        private float vectorZ;

        public OpenGL3DWindow(float vectorX, float vectorY, float vectorZ)
            : base(900, 700, GraphicsMode.Default, "Grafic 3D cu Vector Rotit")
        {
            this.vectorX = vectorX;
            this.vectorY = vectorY;
            this.vectorZ = vectorZ;

            VSync = VSyncMode.On; // Activăm VSync pentru animație fluidă
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color4.Black); // Fundalul graficului

            // Activăm funcționalitatea 3D
            GL.Enable(EnableCap.DepthTest);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(0, 0, Width, Height);

            // Setăm matricea de proiecție
            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.DegreesToRadians(45f), Width / (float)Height, 0.1f, 100f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspective);
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

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            // Setăm matricea model-view
            Matrix4 modelview = Matrix4.LookAt(
                new Vector3(6, 6, 6), // Poziția camerei
                Vector3.Zero,         // Punctul țintă (originea)
                Vector3.UnitY);       // Vectorul "up"
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelview);

            // Desenăm grila, axele și vectorul
            DrawGrid();
            DrawAxes();
            DrawAxisLabels(); // Apelăm noua metodă
            HighlightOrigin();
            DrawRotatingVector();

            SwapBuffers();
        }





        private void DrawAxes()
        {
            GL.LineWidth(2.0f); // Grosimea axelor
            GL.Begin(PrimitiveType.Lines);

            // Axa X - roșu (extinsă la ±10)
            GL.Color3(1f, 0f, 0f);
            GL.Vertex3(-10, 0, 0); // Extindere spre stânga
            GL.Vertex3(10, 0, 0);  // Extindere spre dreapta

            // Axa Y - verde (extinsă la ±10)
            GL.Color3(0f, 1f, 0f);
            GL.Vertex3(0, -10, 0); // Extindere în jos
            GL.Vertex3(0, 10, 0);  // Extindere în sus

            // Axa Z - albastru (extinsă la ±10)
            GL.Color3(0f, 0f, 1f);
            GL.Vertex3(0, 0, -10); // Extindere în spate
            GL.Vertex3(0, 0, 10);  // Extindere în față

            GL.End();
        }


        private void DrawRotatingVector()
        {
            GL.PushMatrix();

            // Aplicăm rotația
            GL.Rotate(angle, 0.0, 1.0, 0.0); // Rotație în jurul axei Y

            // Setăm grosimea liniei pentru vector
            GL.LineWidth(2.5f); // Vector alb mai gros

            // Desenăm vectorul
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(1f, 1f, 1f); // Culoare albă
            GL.Vertex3(0, 0, 0);   // Originea
            GL.Vertex3(vectorX, vectorY, vectorZ); // Punctul final al vectorului
            GL.End();

            GL.PopMatrix();
        }


        private void DrawGrid()
        {
            GL.LineWidth(1.0f); // Grosimea liniilor pentru grid
            GL.Color3(0.3f, 0.3f, 0.3f); // Culoare gri mai închis pentru grid

            // Linii pe planul XY
            GL.Begin(PrimitiveType.Lines);
            for (float i = -10; i <= 10; i += 1.0f) // Extindere la ±10
            {
                // Linii paralele cu axa X
                GL.Vertex3(-10, i, 0);
                GL.Vertex3(10, i, 0);

                // Linii paralele cu axa Y
                GL.Vertex3(i, -10, 0);
                GL.Vertex3(i, 10, 0);
            }
            GL.End();

            // Linii pe planul XZ
            GL.Begin(PrimitiveType.Lines);
            for (float i = -10; i <= 10; i += 1.0f)
            {
                // Linii paralele cu axa X
                GL.Vertex3(-10, 0, i);
                GL.Vertex3(10, 0, i);

                // Linii paralele cu axa Z
                GL.Vertex3(i, 0, -10);
                GL.Vertex3(i, 0, 10);
            }
            GL.End();

            // Linii pe planul YZ
            GL.Begin(PrimitiveType.Lines);
            for (float i = -10; i <= 10; i += 1.0f)
            {
                // Linii paralele cu axa Y
                GL.Vertex3(0, -10, i);
                GL.Vertex3(0, 10, i);

                // Linii paralele cu axa Z
                GL.Vertex3(0, i, -10);
                GL.Vertex3(0, i, 10);
            }
            GL.End();
        }


        private void DrawAxisTicks()
        {
            GL.LineWidth(2.0f); // Grosimea liniilor pentru gradări
            GL.Color3(1.0f, 1.0f, 1.0f); // Culoare albă pentru gradări

            GL.Begin(PrimitiveType.Lines);

            // Gradări pe axa X
            for (float i = -5; i <= 5; i += 1.0f)
            {
                GL.Vertex3(i, -0.1f, 0); // Marcaj jos
                GL.Vertex3(i, 0.1f, 0);  // Marcaj sus
            }

            // Gradări pe axa Y
            for (float i = -5; i <= 5; i += 1.0f)
            {
                GL.Vertex3(-0.1f, i, 0); // Marcaj stânga
                GL.Vertex3(0.1f, i, 0);  // Marcaj dreapta
            }

            // Gradări pe axa Z
            for (float i = -5; i <= 5; i += 1.0f)
            {
                GL.Vertex3(0, -0.1f, i); // Marcaj jos
                GL.Vertex3(0, 0.1f, i);  // Marcaj sus
            }

            GL.End();
        }

        private void HighlightOrigin()
        {
            GL.PointSize(5.0f); // Mărimea punctului
            GL.Begin(PrimitiveType.Points);
            GL.Color3(1f, 1f, 0f); // Culoare galbenă
            GL.Vertex3(0, 0, 0);   // Punctul la origine
            GL.End();
        }

        private void DrawTextOpenGL(string text, float x, float y, float z)
        {
            // Setăm poziția textului în spațiul 3D
            GL.RasterPos3(x, y, z);


        }

        private void DrawAxisLabels()
        {
            GL.LineWidth(2.0f); // Grosimea liniilor pentru marcaje
            GL.Color3(1.0f, 1.0f, 1.0f); // Culoare albă pentru marcaje și etichete

            GL.Begin(PrimitiveType.Lines);

            // Marcaje și etichete pe axa X
            for (int i = -10; i <= 10; i++)
            {
                GL.Vertex3(i, -0.1f, 0); // Marcaj jos
                GL.Vertex3(i, 0.1f, 0);  // Marcaj sus

                // Eticheta numerică pentru axa X
                if (i != 0) // Sărim peste eticheta la origine
                    DrawTextOpenG(i.ToString(), i, -0.3f, 0); // Etichetă puțin sub marcaj
            }

            // Marcaje și etichete pe axa Y
            for (int i = -10; i <= 10; i++)
            {
                GL.Vertex3(-0.1f, i, 0); // Marcaj stânga
                GL.Vertex3(0.1f, i, 0);  // Marcaj dreapta

                // Eticheta numerică pentru axa Y
                if (i != 0) // Sărim peste eticheta la origine
                    DrawTextOpenG(i.ToString(), -0.3f, i, 0); // Etichetă puțin lateral
            }

            // Marcaje și etichete pe axa Z
            for (int i = -10; i <= 10; i++)
            {
                GL.Vertex3(0, -0.1f, i); // Marcaj jos
                GL.Vertex3(0, 0.1f, i);  // Marcaj sus

                // Eticheta numerică pentru axa Z
                if (i != 0) // Sărim peste eticheta la origine
                    DrawTextOpenG(i.ToString(), 0, -0.3f, i); // Etichetă puțin în spate
            }

            GL.End();
        }


        private void DrawTextOpenG(string text, float x, float y, float z)
        {
            // Setăm poziția textului în spațiul 3D
            GL.RasterPos3(x, y, z);

            foreach (char c in text)
            {
                // Renderizăm fiecare caracter folosind FreeType sau o metodă custom de text
                GL.Bitmap(0, 0, 0, 0, 8, 0, Encoding.ASCII.GetBytes(new[] { c }));
            }
        }

    }

}
