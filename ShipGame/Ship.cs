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
    internal class Ship
    {
        
        public PointF[] points = new PointF[3];
        public PointF center;

        /// <summary>
        /// The pen drawing the object
        /// </summary>
        public Pen pen { get; set; }

        /// <summary>
        /// The Size of the canvas.
        /// </summary>
        public Size bounds { get; set; }
        
        /// <summary>
        /// The Color of the canvas,
        /// </summary>
        public Color bgc { get; set; }

        /// <summary>
        /// The current angle of direction in degrees relative to the origin.
        /// </summary>
        public float angle { get; set; }

        /// <summary>
        /// Creates an Object at a given point.
        /// </summary>
        /// <param name="center">The Location of the center of the Object</param>
        /// <param name="c">The color of the object.</param>
        /// <param name="bounds">The size of the current canvas.</param>
        public Ship(PointF center, Color c,  Size bounds) {
            this.bounds = bounds; 
            this.bgc = bgc;
            this.pen = new Pen(c,3);
            this.points[0] = new PointF(center.X, center.Y - 30);
            this.points[1] = new PointF(center.X -20, center.Y +30);
            this.points[2] = new PointF(center.X + 20, center.Y + 30);
            this.center = center;
        }

        /// <summary>
        /// Given a paint surface, paints the object to the canvas.
        /// </summary>
        /// <param name="e"></param>
        public void Draw(PaintEventArgs e)
        {
           e.Graphics.DrawPolygon(pen, points);
        }

        /// <summary>
        /// Give a shallow copy of the list of points.
        /// </summary>
        /// <returns>PointF[] of points that define the object.</returns>
        public PointF[] GetPoints()
        {
            PointF[] ret = (PointF[])points.Clone();
            return points;
        }

        /// <summary>
        /// Sets a new PointF array to draw.
        /// </summary>
        /// <param name="newPoints">Array of PointFs of at least length 2</param>
        public void SetPoints(PointF[] newPoints)
        {
            if (newPoints != null && newPoints.Length >= 2) { 
            PointF[] set = (PointF[])newPoints.Clone();
            this.points = set;
            }
        }

        /// <summary>
        /// Determines if 2 polygons intersect
        /// </summary>
        /// <param name="other">The other polygon's list of defining points.</param>
        /// <returns>False if other polygon is not at least a line or not interseting. True if intersecting</returns>
        public bool CheckCollision(PointF[] other)
        {
            int A = 0,
                B = 1,
                C = 2,
                nexti,
                nextj;
            double[] line1, line2;
            double chk, x, y;
            if (other.Length < 2) return false;//TODO check if in area
            for (int i = 0; i < points.Length; i++) 
            { 
                for (int j = 0; j < other.Length; j++)
                {
                    if (i + 1 != points.Length) nexti = i+1;
                    else nexti = 0;
                    line1 = ABC(points[i], points[nexti]);

                    if (j + 1 != other.Length) nextj = j + 1;
                    else nextj = 0;
                    line2 = ABC(other[j], other[nextj]);

                    chk = (line1[0] * line2[1]) - (line2[0] * line1[1]);
                    if (chk != 0)
                    {
                        x = ((line2[B] * line1[C]) - (line1[B] * line2[C])) / chk;
                        y = ((line1[A] * line2[C]) - (line2[A] * line1[C])) / chk;
                        Console.WriteLine("X:{0} y:{1}", x, y);
                        if (x <= Math.Max(points[i].X, points[nexti].X) &&
                            x >= Math.Min(points[i].X, points[nexti].X) &&
                            y <= Math.Max(points[i].Y, points[nexti].Y) &&
                            y >= Math.Min(points[i].Y, points[nexti].Y) &&
                            x <= Math.Max(other[j].X, other[nextj].X) &&
                            x >= Math.Min(other[j].X, other[nextj].X) &&
                            y <= Math.Max(other[j].Y, other[nextj].Y) &&
                            y >= Math.Min(other[j].Y, other[nextj].Y))
                            return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Given 2 points returns the line in the ABC format.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>double[] ABC representing the function of the line.</returns>
        private double[] ABC(PointF p1, PointF p2)
        {
            double A, B, C;
            A = p2.Y - p1.Y;
            B = p1.X - p2.X;
            C = A * p1.X + B * p1.Y;
            double [] ret = { A, B, C };
            return ret;
        }

        /// <summary>
        /// Rotates a given point by a given angle around a center point.
        /// </summary>
        /// <param name="point">The point to rotate.</param>
        /// <param name="center">The Center to rotate the point around.</param>
        /// <param name="a">The anlge to rotate by in degrees.</param>
        /// <returns></returns>
        public PointF Rotate(PointF point, PointF center, float a)
        {
            PointF ret;
            return ret = 
                new PointF(
                    //px' = cos(theta) * (px-ox) - sin(theta) * (py-oy) + ox
                    (float)(Math.Cos(a * (float)(Math.PI / 180))
                    * (point.X - center.X)
                    - Math.Sin(a * (float)(Math.PI / 180))
                    * (point.Y - center.Y)
                    + center.X),
                    //py' = sin(theta) * (px-ox) + cos(theta) * (py-oy) + oy
                    (float)(Math.Sin(a * (float)(Math.PI / 180))
                    * (point.X - center.X)
                    + Math.Cos(a * (float)(Math.PI / 180))
                    * (point.Y - center.Y)
                    + center.Y)
                    );
        }

        /// <summary>
        /// Moves a given point a given distance along the objects current angle.
        /// </summary>
        /// <param name="point">The point to move.</param>
        /// <param name="distance">The distance to move the point.</param>
        /// <returns>The point at its new locaiton.</returns>
        public PointF Translate(PointF point, float distance)
        {
            PointF ret;
            return ret = new PointF(
                    //px' = px + cos(ang) * distance
                    point.X + (float)Math.Sin(-this.angle * (float)(Math.PI / 180)) * (-distance),
                    //py' = py + sin(ang) * distance
                    point.Y + (float)Math.Cos(-this.angle * (float)(Math.PI / 180)) * (-distance)
                    );
        }

        /// <summary>
        /// Moves a given point a given distance along a given angle in degrees.
        /// </summary>
        /// <param name="point">The point to move.</param>
        /// <param name="distance">The distance to move the point.</param>
        /// <param name="angle">The angle relative to the normal to translate by</param>
        /// <returns>The point at its new locaiton.</returns>
        public PointF Translate(PointF point, float distance, float angle)
        {
            PointF ret;
            return ret = new PointF(
                    //px' = px + cos(ang) * distance
                    point.X + (float)Math.Sin(-angle * (float)(Math.PI / 180)) * (-distance),
                    //py' = py + sin(ang) * distance
                    point.Y + (float)Math.Cos(-angle * (float)(Math.PI / 180)) * (-distance)
                    );
        }

        /// <summary>
        /// Will move the object with a given angle and distance
        /// </summary>
        /// <param name="a">Angle as Degrees</param>
        /// <param name="distance">Distance in pixels to move along current angle.</param>
        public void move(float a, float distance)
        {

            this.angle += a;
            if (angle < 1) angle = 360;
            if (angle > 360) angle = 1;
            
            for (int i = 0; i < points.Length; i++){
                points[i] = Rotate(points[i],this.center,a);
                points[i] = Translate(points[i],distance);
            }
            center = Translate(center,distance);
            
            float   transX = 0, 
                    transY = 0;

            if (center.X < 0)
            {
                transX = bounds.Width;
            }
            if (center.Y < 0)
            {
                transY = bounds.Height;
            }
            if (center.X > bounds.Width)
            {
                transX = -bounds.Width;
            }
            if (center.Y > bounds.Height)
            {
                transY = -bounds.Height;
            }

            for (int i = 0; i < points.Length; i++)
            {
                points[i].X += transX;
                points[i].Y += transY;
            }
            center.X += transX;
            center.Y += transY;
            transX = 0;
            transY = 0;

        }


    }
}
