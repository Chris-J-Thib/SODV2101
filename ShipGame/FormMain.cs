using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using test;

namespace ShipGame
{
    public partial class FormMain : Form
    {
        Random rnd = new Random();
        List<Astroid> aField = new List<Astroid>();
        Ship player;
        Color playerColor = Color.Purple;
        Color bgc = Color.White;


        bool    W = false,
                A = false,
                S = false,
                D = false,
                FIRE = false;
        
        float   ang = 0,
                dis = 0,
                maxA = 6,
                maxD = 5,
                delA = .12f,
                delD = .1f;

        const int   TICKRATE = 1,
                    COUNT = 10,
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
            score.Text = "0";
            player = new Ship(center, new SolidBrush(playerColor), this.Size);
            t.Interval = TICKRATE;
            t.Enabled = true;
            this.DoubleBuffered = true;
            PopulateField();
        }

        private PointF RandomLocation()
        {
            PointF ret = new PointF(10,10);
            int edge = rnd.Next(4);
            switch (edge)
            {
                case 0://top
                    ret = new PointF(rnd.Next(0,WIDTH),10);
                    break;
                case 1://right
                    ret = new PointF(WIDTH - 10, rnd.Next(0, HEIGHT));
                    break;
                case 2://bottom
                    ret = new PointF(rnd.Next(0, WIDTH), HEIGHT - 10);
                    break;
                case 3://left
                    ret = new PointF(10, rnd.Next(0, HEIGHT));
                    break;
            }
            return ret;

        }

        private void PopulateField()
        {
            for (int i = 0; i < COUNT; i++)
            {
                aField.Add(NewAstroid());
            }
        }

        private Astroid NewAstroid()
        {
            return new Astroid(RandomLocation(), new HatchBrush(HatchStyle.Sphere, RandomAstroidColor()), this.Size, rnd.Next(1, (int)Math.Ceiling(maxD / 10)), rnd.Next(1, 360));
        }

        private Color RandomAstroidColor()
        {
            int r,g, b = rnd.Next(96, 192);
            r = rnd.Next(b, b + 31);
            g = rnd.Next(b,r+1);

            return Color.FromArgb(r,g,b);
        }


        private void FormLoad(object sender, EventArgs e)
        {
            this.Invalidate(); //Redraws the canvas with double buffer
        }

        public Size GetSize()
        {
            return this.Size;
        }

        private void FormPaint(object sender, PaintEventArgs e)
        {
            if(player == null) return;
            if (W && dis < maxD) dis += delD;
            if (A && ang > -maxA) ang -= delA;
            if (S && dis > -maxD) dis -= delD;
            if (D && ang < maxA) ang += delA;
            player.Move(ang, dis);
            if (!W && dis > 0) dis -= delD / 4;
            if (!A && ang < 0) ang += delA / 4;
            if (!S && dis < 0) dis += delD / 4;
            if (!D && ang > 0) ang -= delA / 4;
            if (ang < 0.01 && ang > -0.01) ang = 0;
            foreach (Astroid a in aField.ToList())
            {
                if (FIRE)
                {
                    PointF[] lazer = player.Shoot(e);
                    if (a.CheckCollision(lazer))

                    {
                        Astroid[] parts = a.Break(lazer);
                        if (parts != null) aField.AddRange(parts);
                        score.Text = (Int32.Parse(score.Text) + a.value + (int)Math.Ceiling(Math.Abs(dis) + Math.Abs(ang))).ToString();
                    }
                }
                if (!a.exists) 
                { 
                    aField.Remove(a);
                    aField.Add(NewAstroid());
                }
                a.Move();
                a.Draw(e);
                if (a.CheckCollision(player.GetPoints())) EndGame();
            }
            if (aField.Count > COUNT) aField.Remove(aField.First());
            FIRE = false;
            player.Draw(e);
        }
        private void FormClick(object sender, MouseEventArgs e)
        {
            FIRE = true;
        }

        private void EndGame()
        {
            player = null;
            aField.Clear();
            string message = "Game Over!\nYour Score Was\n"+score.Text+"\nPlay Again?";
            if (MessageBox.Show(message,"GAME OVER",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                Close();
            }
            score.Text = "0";
            dis = ang = 0;
            W = A = S = D = false;
            player = new Ship(center, new SolidBrush(playerColor), this.Size);
            PopulateField();
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
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
