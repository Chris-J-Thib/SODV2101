using ShipGame;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{    
    internal class Astroid : Entity
    { 
        private static Random rnd = new Random();
        private const int   _maxSides = 12,
                            _minSides = 5,
                            _maxSize = 100,
                            _minSize = 30,
                            _maxSpin = 6;

        public int size { get; private set; } = 0;

        public int value = _maxSize;
        public int speed { get; set; }
        public int spin { get; set; }
        public bool exists { get; set; } = true;

        public void Move()
        {
            if (exists)
            {
                base.Move(0, (float)speed);
                List<PointF> np = new List<PointF>();
                foreach (PointF p in GetPoints())
                {
                    np.Add(Rotate(p, GetCenter(), spin));
                }
                SetPoints(np.ToArray());
                if (!InBounds()) exists = false;
            }
        }

        public new void Draw(PaintEventArgs e)
        {
            if (exists)
            {
                base.Draw(e);
            }
        }

        public Astroid(PointF center, Brush brush, Size bounds, int speed, float direction) : base(center, brush, bounds)
        {
            this.size = rnd.Next(_minSize, _maxSize);
            SetPoints(genAstroid());
            this.speed = speed;
            this.angle = direction;
            this.spin = rnd.Next(-_maxSpin,_maxSpin);
            if (this.spin == 0) spin++;
        }

        public Astroid(PointF center, Brush brush, Size bounds, int speed, float direction, int size) : base(center, brush, bounds)
        {
            this.size = size;
            SetPoints(genAstroid());
            this.speed = speed;
            this.angle = direction;
            this.spin = rnd.Next(-_maxSpin, _maxSpin);
            if (this.spin == 0) spin++;
        }

        private PointF[] genAstroid()
        {
            value -= size;
            value += speed;
            PointF[] ret = new PointF[rnd.Next(_minSides,_maxSides+1)];
            float side = (float)(2*Math.Sin(180/ret.Length)*size);
            float a = (float)(360/ ret.Length);
            for (int i = 0; i < ret.Length; i++)
            {
                if (i == 0)
                {
                    ret[i] = new PointF(GetCenter().X, GetCenter().Y - size);
                }
                else
                {
                    ret[i] = Rotate(new PointF(ret[i - 1].X, ret[i - 1].Y),GetCenter(),a);
                }
            }
            return ret;
        }

        public Astroid[] Break(PointF[] line)
        {
            if(line == null || line.Length != 2) return null;
            Astroid[] parts = new Astroid[2];
            this.exists = false;
            if (size*2/3 >= _minSize)
            {
                float angle = (float)(Math.Atan2((line[1].Y - line[0].Y), (line[1].X - line[0].X)) * (180 / Math.PI));
                parts[0] = new Astroid(GetCenter(), brush, bounds, speed, angle, size*2/3);
                parts[0].size = size / 2;
                parts[1] = new Astroid(GetCenter(), brush, bounds, speed, angle + 180, size*2/3);
                parts[1].size = size / 2;
                return parts;
            }
            else return null;
        }


    }
}
