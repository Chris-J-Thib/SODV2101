using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slidePuzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void moveTile(object sender, EventArgs e)
        {
            Control c;
            TableLayoutPanelCellPosition point = grid.GetCellPosition((Label)sender);
            Console.WriteLine(point);


            if (point.Column == 0 && point.Row == 0)
            {

                c = grid.GetControlFromPosition(point.Column + 1, point.Row);
                if (c == null)
                {
                   
                }
                c = grid.GetControlFromPosition(point.Column, point.Row + 1);
                Console.WriteLine(c);
            }

            


        }
    }
}
