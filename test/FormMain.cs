using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipGame
{
    public partial class FormMain : Form
    {
        Ship s;
        Color shipColor = Color.Purple;
        Color bgc = Color.White;
        int centerX;
        int centerY;
        


        Rectangle r = new Rectangle(new Point(10, 10), new Size(25, 15));

        public FormMain()
        {
            InitializeComponent();
            centerX = this.Size.Width / 2;
            centerY = this.Size.Height / 2; 
        }

        private void FormLoad(object sender, EventArgs e)
        {
            s = new Ship(centerX, centerY, shipColor);
        }

        private void FormPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(bgc);
            s.Draw(e);
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine( e.KeyData);
            
            switch (e.KeyData.ToString())
            {
                case "W":
                    s.move(0,5);
                    break;
                case "S":
                    s.move(0,-5);
                    break;
                case "D":
                    s.move(6,0);
                    break;
                case "A":
                    s.move(-6,0);
                    break;
            }

            FormPaint(null,new PaintEventArgs( Graphics.FromHwnd(this.Handle), this.Bounds));

        }

    }
}
