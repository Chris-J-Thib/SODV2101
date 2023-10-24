using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ShipGame
{
    internal class Ship : Entity
    {
        public int shipHeight { get; set; } = 60;
        public int shipWidth { get; set; } = 40;
        public Ship(PointF center, Brush brush, Size bounds) : base(center, brush, bounds)
        {
            PointF[] points = new PointF[3];
            points[0] = new PointF(GetCenter().X, GetCenter().Y - shipHeight/2);
            points[1] = new PointF(GetCenter().X - shipWidth/2, GetCenter().Y + shipHeight/2);
            points[2] = new PointF(GetCenter().X + shipWidth/2, GetCenter().Y + shipHeight/2);
            SetPoints(points);
        }

        public new void Move(float a, float distance)
        {
            base.Move(a, distance);
            if (!InBounds()) Warp();
        }

        public PointF[] Shoot(PaintEventArgs e)
        {
            PointF[] lazer = new PointF[2];
            lazer[0] = Translate(GetCenter(),shipHeight/2);
            lazer[1] = Translate(GetCenter(),(float)Math.Sqrt(Math.Pow(bounds.Width,2)+ Math.Pow(bounds.Height, 2)));
            e.Graphics.DrawPolygon(new Pen(Color.Red, 3), lazer);
            return lazer;
        }

        /// <summary>
        /// Warps the ship back in bounds on the opposite side.
        /// </summary>
        public void Warp()
        {
            if (GetCenter().X < 0)
            {
                SetCenter(new PointF(bounds.Width,GetCenter().Y));
            }
            if (GetCenter().Y < 0)
            {
                SetCenter(new PointF(GetCenter().X, bounds.Height));
            }
            if (GetCenter().X > bounds.Width)
            {
                SetCenter(new PointF(0, GetCenter().Y));
            }
            if (GetCenter().Y > bounds.Height)
            {
                SetCenter(new PointF(GetCenter().X, 0));
            }
        }

    }
}
