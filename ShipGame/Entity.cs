using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipGame
{
    internal class Entity
    {

        private PointF center;
        private PointF[] points;

        /// <summary>
        /// Used to turn on/off point labeling for debugging.
        /// </summary>
        public bool drawLabels { get;  set; } = false;

        /// <summary>
        /// The pen drawing the object
        /// </summary>
        public Brush brush { get; set; }

        /// <summary>
        /// The Size of the canvas.
        /// </summary>
        public Size bounds { get; set; }

        /// <summary>
        /// The current angle of direction in degrees relative to the origin.
        /// </summary>
        public float angle { get; set; } = 0;

        /// <summary>
        /// Creates an Object at a given point.
        /// </summary>
        /// <param name="center">The Location of the center of the Object</param>
        /// <param name="c">The color of the object.</param>
        /// <param name="bounds">The size of the current canvas.</param>
        public Entity(PointF center, Brush brush, Size bounds)
        {
            this.bounds = bounds;
            this.brush = brush;
            this.center = center;
        }

        /// <summary>
        /// Given a paint surface, paints the object to the canvas.
        /// </summary>
        /// <param name="e"></param>
        public void Draw(PaintEventArgs e)
        {
            if (points == null || points.Length == 0) return;
            e.Graphics.FillPolygon(brush, points);
            if (drawLabels)
            {
                LabelPoint(e, center, "c");
                for (int i = 0; i < points.Length; i++)
                {
                    LabelPoint(e, points[i], (1 + i).ToString());
                }
            }
        }

        /// <summary>
        /// Labels a Point, used for debugging
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <param name="labelText"></param>
        public void LabelPoint(PaintEventArgs e, PointF p, String labelText)
        {
            e.Graphics.DrawString(labelText,
                                    new Font(FontFamily.GenericSansSerif, 12),
                                    new SolidBrush(Color.Black),
                                    p.X,
                                    p.Y);
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

        public PointF GetCenter()
        {
            return center;
        }

        public void SetCenter(PointF p)
        {
            float   x = p.X - center.X,
                    y = p.Y - center.Y;

            center = p;

            PointF[] ps = GetPoints();
            for (int i = 0; i < GetPoints().Length;i++) 
            {
                ps[i].X += x;
                ps[i].Y += y;
            }
        }

        /// <summary>
        /// Sets a new PointF array to draw.
        /// </summary>
        /// <param name="newPoints">Array of PointFs of at least length 2</param>
        public void SetPoints(PointF[] newPoints)
        {
            if (newPoints != null && newPoints.Length >= 2)
            {
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
                    if (i + 1 != points.Length) nexti = i + 1;
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
            double[] ret = { A, B, C };
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
        /// Will move the object with a given angle and distance
        /// </summary>
        /// <param name="a">Angle as Degrees</param>
        /// <param name="distance">Distance in pixels to move along current angle.</param>
        public void Move(float a, float distance)
        {

            this.angle += a;
            if (angle < 1) angle = 360;
            if (angle > 360) angle = 1;

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = Rotate(points[i], this.center, a);
                points[i] = Translate(points[i], distance);
            }
            center = Translate(center, distance);
        }

        /// <summary>
        /// Checks to see if the center of the polygon is in the given bounds.
        /// </summary>
        /// <returns>True if in bound, False if not</returns>
        public bool InBounds()
        {
            return (center.X >= 0 && center.X <= bounds.Width
                            &&
                    center.Y >= 0 && center.Y <= bounds.Height);
        }
    }
}
