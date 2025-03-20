using System;
using System.Drawing;
using System.Windows.Forms;

namespace VectorOps
{
    public class RotatingVector2DForm : Form
    {
        private float angle = 0f; // Rotation angle in degrees
        private float vectorX;    // X coordinate of the vector
        private float vectorY;    // Y coordinate of the vector
        private Timer timer;

        public RotatingVector2DForm(float vectorX, float vectorY)
        {
            this.vectorX = vectorX;
            this.vectorY = vectorY;

            this.Text = "Rotating 2D Vector";
            this.Size = new Size(800, 600);
            this.DoubleBuffered = true;

            // Configure the timer for animation
            timer = new Timer();
            timer.Interval = 50; // Update every 50 ms
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            angle += 2f; // Increase the angle by 2 degrees on each update
            if (angle >= 360f)
                angle -= 360f;

            this.Invalidate(); // Redraw the window
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            float scale = 40f;

            this.BackColor = Color.FromArgb(45, 45, 45); // Dark gray

            // Draw the grid and axes
            DrawGrid(g, centerX, centerY, scale);
            DrawAxes(g, centerX, centerY);

            // Calculate the new position of the vector after rotation
            float rotatedX = (float)(vectorX * Math.Cos(DegreeToRadian(angle)) - vectorY * Math.Sin(DegreeToRadian(angle)));
            float rotatedY = (float)(vectorX * Math.Sin(DegreeToRadian(angle)) + vectorY * Math.Cos(DegreeToRadian(angle)));

            // Draw the rotated vector
            DrawVector(g, centerX, centerY, rotatedX, rotatedY, scale);

            // Labels for the vector
            AddLabels(g, centerX, centerY, rotatedX, rotatedY, scale);
        }

        private void DrawAxes(Graphics g, int centerX, int centerY)
        {
            Pen axisXPen = new Pen(Color.Orange, 2); // X axis - orange
            Pen axisYPen = new Pen(Color.LightGreen, 2); // Y axis - light green

            // X axis
            g.DrawLine(axisXPen, 0, centerY, this.ClientSize.Width, centerY);

            // Y axis
            g.DrawLine(axisYPen, centerX, 0, centerX, this.ClientSize.Height);

            // Labels for the X and Y axes
            Font font = new Font("Arial", 16);

            // Label for the X axis
            g.DrawString("X", font, Brushes.Orange, this.ClientSize.Width - 35, centerY - 25);

            // Label for the Y axis
            g.DrawString("Y", font, Brushes.LightGreen, centerX - 35, 10);

            // Label for the -X axis
            g.DrawString("-X", font, Brushes.Orange, 10, centerY - 25);

            // Label for the -Y axis
            g.DrawString("-Y", font, Brushes.LightGreen, centerX - 35, this.ClientSize.Height - 30);

        }

        private void DrawVector(Graphics g, int centerX, int centerY, float x, float y, float scale)
        {
            Pen vectorPen = new Pen(Color.Red, 3);
            vectorPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            // The end point of the vector
            float endX = centerX + x * scale;
            float endY = centerY - y * scale;

            // Draw the vector
            g.DrawLine(vectorPen, centerX, centerY, endX, endY);
        }

        private void AddLabels(Graphics g, int centerX, int centerY, float x, float y, float scale)
        {
            Font font = new Font("Arial", 10);
            Brush labelBrush = Brushes.White;

            // Label for the end point of the vector
            float endX = centerX + x * scale;
            float endY = centerY - y * scale;

            g.DrawString($"({x:F1}, {y:F1})", font, labelBrush, endX + 5, endY - 20);

            // Ticks on the X and Y axes
            int unitsX = this.ClientSize.Width / 2 / (int)scale; // Number of units on the X axis
            int unitsY = this.ClientSize.Height / 2 / (int)scale; // Number of units on the Y axis

            for (int i = -unitsX; i <= unitsX; i++)
            {
                if (i != 0)
                {
                    // Ticks and labels on the X axis
                    float xPos = centerX + i * scale;
                    g.DrawString(i.ToString(), font, labelBrush, xPos - 10, centerY + 5); // Label below the axis
                }
            }

            for (int i = -unitsY; i <= unitsY; i++)
            {
                if (i != 0)
                {
                    // Ticks and labels on the Y axis
                    float yPos = centerY - i * scale;
                    g.DrawString(i.ToString(), font, labelBrush, centerX + 5, yPos - 10); // Label to the right of the axis
                }
            }
        }

        private void DrawGrid(Graphics g, int centerX, int centerY, float scale)
        {
            Pen gridPen = new Pen(Color.FromArgb(70, 70, 70), 1); // Lighter gray for the grid

            // Vertical lines
            int unitsX = this.ClientSize.Width / 2 / (int)scale; // Number of units on the X axis
            for (int i = -unitsX; i <= unitsX; i++)
            {
                float x = centerX + i * scale;
                g.DrawLine(gridPen, x, 0, x, this.ClientSize.Height);
            }

            // Horizontal lines
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
