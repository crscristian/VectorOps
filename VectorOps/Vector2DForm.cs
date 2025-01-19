using System;
using System.Drawing;
using System.Windows.Forms;

namespace VectorOps
{
    public class RotatingVector2DForm : Form
    {
        private float angle = 0f; // Unghiul de rotație în grade
        private float vectorX;    // Coordonata X a vectorului
        private float vectorY;    // Coordonata Y a vectorului
        private Timer timer;

        public RotatingVector2DForm(float vectorX, float vectorY)
        {
            this.vectorX = vectorX;
            this.vectorY = vectorY;

            this.Text = "Vector 2D Rotativ";
            this.Size = new Size(800, 600);
            this.DoubleBuffered = true;

            // Configurăm timer-ul pentru animație
            timer = new Timer();
            timer.Interval = 50; // Actualizare la fiecare 50 ms
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            angle += 2f; // Creștem unghiul cu 2 grade la fiecare actualizare
            if (angle >= 360f)
                angle -= 360f;

            this.Invalidate(); // Re-desenăm fereastra
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            float scale = 40f;

            this.BackColor = Color.FromArgb(45, 45, 45); // Gri închis

            // Desenăm grila și axele
            DrawGrid(g, centerX, centerY, scale);
            DrawAxes(g, centerX, centerY);

            // Calculăm noua poziție a vectorului după rotație
            float rotatedX = (float)(vectorX * Math.Cos(DegreeToRadian(angle)) - vectorY * Math.Sin(DegreeToRadian(angle)));
            float rotatedY = (float)(vectorX * Math.Sin(DegreeToRadian(angle)) + vectorY * Math.Cos(DegreeToRadian(angle)));

            // Desenăm vectorul rotit
            DrawVector(g, centerX, centerY, rotatedX, rotatedY, scale);

            // Etichete pentru vector
            AddLabels(g, centerX, centerY, rotatedX, rotatedY, scale);
        }

        private void DrawAxes(Graphics g, int centerX, int centerY)
        {
            Pen axisXPen = new Pen(Color.Orange, 2); // Axă X - portocaliu
            Pen axisYPen = new Pen(Color.LightGreen, 2); // Axă Y - verde deschis

            // Axa X
            g.DrawLine(axisXPen, 0, centerY, this.ClientSize.Width, centerY);

            // Axa Y
            g.DrawLine(axisYPen, centerX, 0, centerX, this.ClientSize.Height);

            // Etichete pentru axele X și Y
            Font font = new Font("Arial", 16);

            // Etichetă pentru axa X
            g.DrawString("X", font, Brushes.Orange, this.ClientSize.Width - 35, centerY - 25);

            // Etichetă pentru axa Y
            g.DrawString("Y", font, Brushes.LightGreen, centerX - 35, 10);

            // Etichetă pentru axa -X
            g.DrawString("-X", font, Brushes.Orange, 10, centerY - 25);

            // Etichetă pentru axa -Y
            g.DrawString("-Y", font, Brushes.LightGreen, centerX - 35, this.ClientSize.Height - 30);

        }

        private void DrawVector(Graphics g, int centerX, int centerY, float x, float y, float scale)
        {
            Pen vectorPen = new Pen(Color.Red, 3);
            vectorPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            // Punctul final al vectorului
            float endX = centerX + x * scale;
            float endY = centerY - y * scale;

            // Desenăm vectorul
            g.DrawLine(vectorPen, centerX, centerY, endX, endY);
        }

        private void AddLabels(Graphics g, int centerX, int centerY, float x, float y, float scale)
        {
            Font font = new Font("Arial", 10);
            Brush labelBrush = Brushes.White;

            // Etichetă pentru punctul final al vectorului
            float endX = centerX + x * scale;
            float endY = centerY - y * scale;

            g.DrawString($"({x:F1}, {y:F1})", font, labelBrush, endX + 5, endY - 20);

            // Gradări pe axele X și Y
            int unitsX = this.ClientSize.Width / 2 / (int)scale; // Număr unități pe axa X
            int unitsY = this.ClientSize.Height / 2 / (int)scale; // Număr unități pe axa Y

            for (int i = -unitsX; i <= unitsX; i++)
            {
                if (i != 0)
                {
                    // Gradări și etichete pe axa X
                    float xPos = centerX + i * scale;
                    g.DrawString(i.ToString(), font, labelBrush, xPos - 10, centerY + 5); // Eticheta sub axă
                }
            }

            for (int i = -unitsY; i <= unitsY; i++)
            {
                if (i != 0)
                {
                    // Gradări și etichete pe axa Y
                    float yPos = centerY - i * scale;
                    g.DrawString(i.ToString(), font, labelBrush, centerX + 5, yPos - 10); // Eticheta în dreapta axei
                }
            }
        }

        private void DrawGrid(Graphics g, int centerX, int centerY, float scale)
        {
            Pen gridPen = new Pen(Color.FromArgb(70, 70, 70), 1); // Gri mai deschis pentru grilă

            // Linii verticale
            int unitsX = this.ClientSize.Width / 2 / (int)scale; // Număr unități pe axa X
            for (int i = -unitsX; i <= unitsX; i++)
            {
                float x = centerX + i * scale;
                g.DrawLine(gridPen, x, 0, x, this.ClientSize.Height);
            }

            // Linii orizontale


            for (int i = -20; i <= 20; i++)
            {
                float y = centerY - i * scale;
                g.DrawLine(gridPen, 0, y, this.ClientSize.Width, y);
            }
        }

        private float DegreeToRadian(float degree)
        {
            return (float)(Math.PI * degree / 180.0);
        }
    }
}
