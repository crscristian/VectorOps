using System;
using System.Drawing;
using System.Windows.Forms;

namespace VectorOps
{
    public class RotatingVector3DForm : Form
    {
        private Timer timer;
        private float angleX = 0f;
        private float angleY = 0f;
        private float angleZ = 0f;

        public RotatingVector3DForm()
        {
            this.Text = "Vector 3D Rotativ cu Grilă";
            this.Size = new Size(800, 600);
            this.DoubleBuffered = true;

            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            angleX += 2f;
            angleY += 2f;
            angleZ += 2f;

            if (angleX >= 360f) angleX -= 360f;
            if (angleY >= 360f) angleY -= 360f;
            if (angleZ >= 360f) angleZ -= 360f;

            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            float scale = 40f;

            this.BackColor = Color.FromArgb(45, 45, 45);

            Draw3DGrid(g, centerX, centerY, scale);
            Draw3DAxes(g, centerX, centerY, scale);
            DrawAxisLabels(g, centerX, centerY, scale);

            Point3D vector = new Point3D(1, 1, 1);
            Point3D rotatedVector = RotateVector(vector, angleX, angleY, angleZ);
            PointF projectedPoint = ProjectPoint(rotatedVector, scale, centerX, centerY);

            DrawVector(g, centerX, centerY, projectedPoint);
        }

        private void Draw3DGrid(Graphics g, int centerX, int centerY, float scale)
        {
            Pen gridPen = new Pen(Color.FromArgb(70, 70, 70), 1);
            int gridSize = 10;

            for (int i = -gridSize; i <= gridSize; i++)
            {
                // Planul XY
                PointF startXY1 = ProjectPoint(new Point3D(-gridSize, i, 0), scale, centerX, centerY);
                PointF endXY1 = ProjectPoint(new Point3D(gridSize, i, 0), scale, centerX, centerY);
                g.DrawLine(gridPen, startXY1, endXY1);

                PointF startXY2 = ProjectPoint(new Point3D(i, -gridSize, 0), scale, centerX, centerY);
                PointF endXY2 = ProjectPoint(new Point3D(i, gridSize, 0), scale, centerX, centerY);
                g.DrawLine(gridPen, startXY2, endXY2);

                // Planul XZ
                PointF startXZ1 = ProjectPoint(new Point3D(-gridSize, 0, i), scale, centerX, centerY);
                PointF endXZ1 = ProjectPoint(new Point3D(gridSize, 0, i), scale, centerX, centerY);
                g.DrawLine(gridPen, startXZ1, endXZ1);

                PointF startXZ2 = ProjectPoint(new Point3D(i, 0, -gridSize), scale, centerX, centerY);
                PointF endXZ2 = ProjectPoint(new Point3D(i, 0, gridSize), scale, centerX, centerY);
                g.DrawLine(gridPen, startXZ2, endXZ2);

                // Planul YZ
                PointF startYZ1 = ProjectPoint(new Point3D(0, -gridSize, i), scale, centerX, centerY);
                PointF endYZ1 = ProjectPoint(new Point3D(0, gridSize, i), scale, centerX, centerY);
                g.DrawLine(gridPen, startYZ1, endYZ1);

                PointF startYZ2 = ProjectPoint(new Point3D(0, i, -gridSize), scale, centerX, centerY);
                PointF endYZ2 = ProjectPoint(new Point3D(0, i, gridSize), scale, centerX, centerY);
                g.DrawLine(gridPen, startYZ2, endYZ2);
            }
        }

        private void Draw3DAxes(Graphics g, int centerX, int centerY, float scale)
        {
            Pen axisPenX = new Pen(Color.Red, 2);
            Pen axisPenY = new Pen(Color.Green, 2);
            Pen axisPenZ = new Pen(Color.Blue, 2);

            // X axis
            Point3D xStart = new Point3D(-10, 0, 0);
            Point3D xEnd = new Point3D(10, 0, 0);
            PointF xStart2D = ProjectPoint(xStart, scale, centerX, centerY);
            PointF xEnd2D = ProjectPoint(xEnd, scale, centerX, centerY);
            g.DrawLine(axisPenX, xStart2D, xEnd2D);

            // Y axis
            Point3D yStart = new Point3D(0, -10, 0);
            Point3D yEnd = new Point3D(0, 10, 0);
            PointF yStart2D = ProjectPoint(yStart, scale, centerX, centerY);
            PointF yEnd2D = ProjectPoint(yEnd, scale, centerX, centerY);
            g.DrawLine(axisPenY, yStart2D, yEnd2D);

            // Z axis
            Point3D zStart = new Point3D(0, 0, -10);
            Point3D zEnd = new Point3D(0, 0, 10);
            PointF zStart2D = ProjectPoint(zStart, scale, centerX, centerY);
            PointF zEnd2D = ProjectPoint(zEnd, scale, centerX, centerY);
            g.DrawLine(axisPenZ, zStart2D, zEnd2D);
        }

        private void DrawAxisLabels(Graphics g, int centerX, int centerY, float scale)
        {
            Font font = new Font("Arial", 10);
            Brush brushX = Brushes.Red;
            Brush brushY = Brushes.Green;
            Brush brushZ = Brushes.Blue;

            for (int i = 1; i <= 10; i++)
            {
                // X Axis
                Point3D xLabelPos = new Point3D(i, 0, 0);
                PointF xLabel2D = ProjectPoint(xLabelPos, scale, centerX, centerY);
                g.DrawString(i.ToString(), font, brushX, xLabel2D);

                // Y Axis
                Point3D yLabelPos = new Point3D(0, i, 0);
                PointF yLabel2D = ProjectPoint(yLabelPos, scale, centerX, centerY);
                g.DrawString(i.ToString(), font, brushY, yLabel2D);

                // Z Axis
                Point3D zLabelPos = new Point3D(0, 0, i);
                PointF zLabel2D = ProjectPoint(zLabelPos, scale, centerX, centerY);
                g.DrawString(i.ToString(), font, brushZ, zLabel2D);
            }
        }

        private void DrawVector(Graphics g, int centerX, int centerY, PointF endPoint)
        {
            Pen vectorPen = new Pen(Color.Yellow, 3)
            {
                EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor
            };

            g.DrawLine(vectorPen, centerX, centerY, endPoint.X, endPoint.Y);
        }

        private Point3D RotateVector(Point3D vector, float angleX, float angleY, float angleZ)
        {
            float radX = DegreeToRadian(angleX);
            float radY = DegreeToRadian(angleY);
            float radZ = DegreeToRadian(angleZ);

            float cosX = (float)Math.Cos(radX);
            float sinX = (float)Math.Sin(radX);
            float y1 = vector.Y * cosX - vector.Z * sinX;
            float z1 = vector.Y * sinX + vector.Z * cosX;

            float cosY = (float)Math.Cos(radY);
            float sinY = (float)Math.Sin(radY);
            float x2 = vector.X * cosY + z1 * sinY;
            float z2 = -vector.X * sinY + z1 * cosY;

            float cosZ = (float)Math.Cos(radZ);
            float sinZ = (float)Math.Sin(radZ);
            float x3 = x2 * cosZ - y1 * sinZ;
            float y3 = x2 * sinZ + y1 * cosZ;

            return new Point3D(x3, y3, z2);
        }

        private PointF ProjectPoint(Point3D point, float scale, int centerX, int centerY)
        {
            float perspective = 400f / (400f + point.Z * scale);
            float x = centerX + point.X * scale * perspective;
            float y = centerY - point.Y * scale * perspective;

            return new PointF(x, y);
        }

        private float DegreeToRadian(float degree)
        {
            return (float)(Math.PI * degree / 180.0);
        }
    }

    public class Point3D
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Point3D(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
