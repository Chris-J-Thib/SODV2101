using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieChart
{
    internal class Pie
    {
        public String type { get; set;}
        public String desc {get; set;}
        public String abrv {get; set;}

        public Color color { get; set;}

        public int count { get; set; } = 0;

        public Pie(string type, string desc, string abrv, Color color)
        {
            this.type = type;
            this.desc = desc;
            this.abrv = abrv;
            this.color = color;
        }


    }
}
