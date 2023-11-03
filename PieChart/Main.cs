using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PieChart
{
    public partial class Main : Form
    {
        Dictionary<String, int> Pies = new Dictionary<String, int>();
        bool first = true;

        public Main()
        {
            InitializeComponent();
            Pies.Add("Apple", 0);
            Pies.Add("Lemon Meringue", 0);
            Pies.Add("Cream", 0);
            Pies.Add("Cherry", 0);
            Pies.Add("Chocolate", 0);
            Pies.Add("Math", 0);
            
            UpdateValues();
            first = false;

        }

        private void UpdateValues()
        {
            Pies.Keys.ToList().ForEach(key =>
            {
                if (first) { Chart.Series.Add(key); }
                Chart.Series[key].Points.Add(Pies[key]);
            });
        }

        private void btnClicked(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.Text == "Clear")
            {
                Pies.Keys.ToList().ForEach(type  => { Pies[type] = 0; });
            }
            else
            {
                Pies[btn.Text]++;
            }
            UpdateValues();
            Pies.ToList().ForEach(i => Console.WriteLine(i));
            Console.WriteLine();
            Refresh();
        }




    }
}
