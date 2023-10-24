using ShipGame;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace test
{    
    internal class Astroid : Ship
    { 

        private static Random rnd = new Random();
        private const int   _maxSides = 28,
                            _minSides = 5, 
                            _maxSize = 30,
                            _minSize = 10;
        public Astroid(PointF center, Color c, Size bounds) : base(center, c, bounds)
        {
            SetPoints(genAstroid());
            
        }

        private PointF[] genAstroid()
        {
            int radius = rnd.Next(_minSize, _maxSize)*3;
            PointF[] ret = new PointF[rnd.Next(_minSides,_maxSides+1)];
            float side = (float)(2*Math.Sin(180/ret.Length)*radius);
            float a = (float)(360/ ret.Length);
            for (int i = 0; i < ret.Length; i++)
            {
                if (i == 0)
                {
                    ret[i] = new PointF(this.center.X, this.center.Y - radius);
                }
                else
                {
                    ret[i] = Rotate(new PointF(ret[i - 1].X, ret[i - 1].Y),center,a);
                }
            }
            return ret;
        }



    }
}
