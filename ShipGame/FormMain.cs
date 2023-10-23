using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test;

namespace ShipGame
{
    public partial class FormMain : Form
    {
        Random rnd = new Random();
        Astroid player, enemy;
        Color playerColor = Color.Purple;
        Color enemyColor = Color.Red;
        Color bgc = Color.White;        

        float   ang = 0,
                dis = 0,
                maxA = 4,
                maxD = 6,
                delA = .03f,
                delD = .05f;
                
        bool    W = false,
                A = false,
                S = false,
                D = false;

        const int TICKRATE = 1,
                    HEIGHT = 720,
                    WIDTH = 1080;

        private static PointF center = new PointF(WIDTH/2,HEIGHT/2);
                    


        public FormMain()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.Size = new Size(WIDTH, HEIGHT);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MaximumSize = this.MinimumSize = this.Size;
            player = new Astroid(center, playerColor, this.Size);
            t.Interval = TICKRATE;
            t.Enabled = true;
            this.DoubleBuffered = true;
        }


        private void FormLoad(object sender, EventArgs e)
        {
            Frame();
        }

        public Size GetSize()
        {
            return this.Size;
        }

        private void Frame()
        {
            if (W && dis <  maxD) dis += delD;
            if (A && ang > -maxA) ang -= delA;
            if (S && dis > -maxD) dis -= delD;
            if (D && ang <  maxA) ang += delA;
            player.move(ang, dis);
            if (!W && dis > 0) dis -= delD/4;
            if (!A && ang < 0) ang += delA/4;
            if (!S && dis < 0) dis += delD/4;
            if (!D && ang > 0) ang -= delA/4;
            if (ang < 0.01 && ang > -0.01) ang = 0;
            //enemy.move(rnd.Next(-(int)maxA, (int)maxA), maxD / 2);
            
            FormPaint(this, new PaintEventArgs(Graphics.FromHwnd(this.Handle), this.Bounds));
        }



        private void FormPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(bgc);
            player.Draw(e);
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            //Console.WriteLine(e.KeyData);
            switch (e.KeyData.ToString())
            {
                case "W":
                    W = true;
                    break;
                case "S":
                    S = true;
                    break;
                case "D":
                    D = true;
                    break;
                case "A":
                    A = true;
                    break;
            }
        }
        private void FormKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData.ToString())
            {
                case "W":
                    W = false;
                    break;
                case "S":
                    S = false;
                    break;
                case "D":
                    D = false;
                    break;
                case "A":
                    A = false;
                    break;
            }
        }



    }
}
