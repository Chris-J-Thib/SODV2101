using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipGame
{
    internal class Ship
    {
        private PointF[] points = new PointF[4];
        public float angle { get; set; }

        public Pen pen;

        public Ship(float centerX, float centerY, Color c) {
            this.pen = new Pen(c,3);
            this.points[0] = new PointF(centerX, centerY - 30);
            this.points[1] = new PointF(centerX -20, centerY +30);
            this.points[2] = new PointF(centerX + 20, centerY + 30);
            this.points[3] = new PointF(centerX, centerY);
        }
        public void Draw(PaintEventArgs e)
        {
            e.Graphics.DrawPolygon(pen, points.Except(new PointF[] { points.Last()}).ToArray());
        }

        public float GetDistance(PointF p2, PointF p1) {
            return (float)Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        public void move(float a, float distance)
        {
            this.angle += a;
            if (angle < 1) angle = 360;
            if (angle > 360) angle = 1;
            PointF next;
            for (int i = 0; i < points.Length; i++)
                //p'x = cos(theta) * (px-ox) - sin(theta) * (py-oy) + ox
                //p'y = sin(theta) * (px-ox) + cos(theta) * (py-oy) + oy
            {
                next = new PointF(
                    (float)(Math.Cos(a * (float)(Math.PI / 180)) 
                    * (points[i].X - points[3].X) 
                    - Math.Sin(a * (float)(Math.PI / 180)) 
                    * (points[i].Y - points[3].Y) 
                    + points[3].X),

                    (float)(Math.Sin(a * (float)(Math.PI / 180))
                    * (points[i].X - points[3].X)
                    + Math.Cos(a * (float)(Math.PI / 180))
                    * (points[i].Y - points[3].Y)
                    + points[3].Y)
                    );
                points[i] = next;
            }
            for (int i = 0; i < points.Length; i++)
                //x1 = x + cos(ang) * distance
                //y1 = y + sin(ang) * distance
            {
                next = new PointF(
                    points[i].X + (float)Math.Sin(-angle * (float)(Math.PI / 180)) * (-distance),
                    points[i].Y + (float)Math.Cos(-angle * (float)(Math.PI / 180)) * (-distance)
                    );
                points[i] = next;
            }
        }


    }
}
