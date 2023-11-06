using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace PieChart
{
    public partial class Main : Form
    {
        string seriesName = "Pies";

        Series pieSeries;

        FormAdd fa;

        List<Pie> pies = new List<Pie>();
        List<Pie> initPies = new List<Pie> {
                new Pie("Apple","Cinnamon Spice n Everything nice.","Ap",Color.Crimson),
                new Pie("Lemon Meringue", "Creamy and tart.","LM",Color.LightYellow),
                new Pie("Cream", "( ͡° ͜ʖ ͡° )", "Cm",Color.Ivory),
                new Pie("Cherry","Sweet red cherry sauce.","Cr",Color.Maroon),
                new Pie("Chocolate","AKA Mud or Dirt pie.","Cl",Color.SaddleBrown),
                new Pie("Math","3.1415926535897932384626433...","π",Color.Lime)
        };

        public Main()
        {
            InitializeComponent();   
        }

        private void UpdateList()
        {
            listPies.Controls.Clear();
            foreach (Pie p in pies)
            {
                TableLayoutPanel t = new TableLayoutPanel();
                Button  bX = new Button(),
                        bS = new Button(),
                        bP = new Button();
                t.Size = new Size(200, 40);
                bX.Size = new Size(t.Height, t.Height);
                bS.Size = new Size(t.Height, t.Height);
                bP.Size = new Size(t.Width-bX.Width-bS.Width,t.Height);
                bX.BackColor = Color.Red;
                bS.BackColor = Color.Yellow;
                bX.ForeColor = Color.White;
                bX.Text = "X";
                bS.Text = "-";
                bX.Click += new EventHandler(btnClicked);
                bP.Click += new EventHandler(btnClicked);
                bS.Click += new EventHandler(btnClicked);
                bX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                bP.Text = p.type;
                t.RowCount = 1;
                t.ColumnCount = 3;
                t.BackColor = Color.White;
                t.Padding =t.Margin=bP.Margin=bX.Margin = bS.Margin= new Padding(0);
                t.Controls.Add(bS,0,0);
                t.Controls.Add(bP, 1, 0);
                t.Controls.Add(bX,2,0);
                listPies.Controls.Add(t);
            }
            UpdatePie();
            Refresh();
        }

        private void UpdatePie()
        {
            Chart.Series.Clear();
            Chart.Series.Add(seriesName);
            pieSeries = Chart.Series[seriesName];
            pieSeries.ChartType = SeriesChartType.Pie;
            pieSeries.Font = new Font(FontFamily.GenericSerif, 20);
            pies.ForEach(p => {
                DataPoint d = new DataPoint();
                d.Color = p.color;
                d.Label = p.abrv;
                d.LabelToolTip = p.desc;
                d.LegendText = $"[{p.count}] {p.type}";
                d.BorderColor = Color.Black;
                d.SetValueY(p.count);
                pieSeries.Points.Add(d);
            });
        }

        private void btnClicked(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.Text == "X")
            {
                btn.Parent.Parent.Controls.Remove(btn.Parent);
                pies.Remove(pies.Find(p=>p.type == btn.Parent.Controls[1].Text));
            } else if(btn.Text == "Add")
            {
                fa = new FormAdd();
                DialogResult res = fa.ShowDialog();
                if (res == DialogResult.OK && fa.type != null)
                {
                    Pie p = new Pie(fa.type,fa.desc,fa.abrv,fa.color);
                    p.count = 1;
                    pies.Add(p);
                }
                
            } else if (btn.Text =="-")
            {
                Pie p = pies.Where(pie => pie.type == btn.Parent.Controls[1].Text).First();
                p.count--;
                if (p.count <= 0) pies.Remove(p);
            } else
            {
                pies.Where(pie => pie.type == btn.Text).First().count++;
            }
            UpdateList();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if(pies != null)pies.Clear();
            initPies.ForEach(p => { p.count = 1; pies.Add(p); });
            UpdateList();
        }

    }
}
