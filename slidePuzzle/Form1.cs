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
        private Label[] tiles;
        private Random rnd = new Random();
        private int tileCount;
        private int rowCount;
        private int colCount;
        public Form1()
        {
            InitializeComponent();
            rowCount = grid.RowCount;
            colCount = grid.ColumnCount;
            SetTiles();


        }

        private void SetTiles()
        {
            tileCount = rowCount * colCount - 1;
            tiles = new Label[tileCount];
            for (int j = 0; j < tiles.Length; j++)
            {
                tiles[j] = new Label();
            }
            int i = 1;
            foreach (Label tile in tiles)
            {
                tile.Font = new Font(FontFamily.GenericSerif, 24, FontStyle.Bold);
                tile.TextAlign = ContentAlignment.MiddleCenter;
                tile.BackColor = Color.White;
                tile.AutoSize= false;
                tile.Size = new Size(90, 90);
                tile.Location = new Point(5, 5);
                tile.Anchor = AnchorStyles.None;
                tile.Text = i++.ToString();
            }
            ClickSolve(null, null);
        }

        private void moveTile(object sender, EventArgs e)
        {
                     


        }

        private void ClickShuffle(object sender, EventArgs e)
        {
            foreach (Control tile in grid.Controls)
            {
                if(grid.GetChildAtPoint(new Point(rnd.Next(0, rowCount), rnd.Next(0, colCount)))== null)
                {

                }
            }
        }

        private void ClickSolve(object sender, EventArgs e)
        {
            grid.Controls.Clear();
            int tile = 0;
            for (int i = 0; i < grid.RowCount; i++)
            {
                for (int j = 0; j < grid.ColumnCount; j++)
                {
                    if (i==2 && j==2)break;
                    grid.Controls.Add(tiles[tile++], j,i);

                }

             }
         }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

