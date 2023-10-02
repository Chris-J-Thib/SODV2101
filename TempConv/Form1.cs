using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConv
{
    public partial class Form1 : Form
    {

        private int[] temps = new int[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn != null)
            {
                if (btn.Name == "buttonNeg")
                {
                    temp1.Text = (Double.Parse(temp1.Text) * -1).ToString();
                }
                else if (btn.Name == "buttonDec")
                {
                    if (!temp1.Text.Contains("."))
                    {
                        temp1.Text += ".";
                    }

                }
                else if (btn.Name == "buttonClear")
                {
                    temp1.Text = "0";
                }
                else if (btn.Name == "buttonBack")
                {
                    temp1.Text = temp1.Text.Remove(temp1.Text.Length - 1, 1);
                    if (temp1.Text.Length == 0)
                    {
                        temp1.Text = "0";
                    }
                }
                else
                {
                    if (temp1.Text[0] == '0')
                    {
                        temp1.Text = btn.Text;
                    }
                    else
                    {
                        temp1.Text += btn.Text;
                    }

                }
            }


            if (unit1.SelectedIndex == 0)
            {

                if (unit2.SelectedIndex == 0)
                {
                    temp2.Text = temp1.Text;
                    temp3.Text = CtoK(temp1.Text);
                    unit3.Text = "K";
                }
                else if (unit2.SelectedIndex == 1)
                {
                    temp2.Text = KtoF(CtoK(temp1.Text));
                    temp3.Text = CtoK(temp1.Text);
                    unit3.Text = "K";
                }
                else
                {
                    temp3.Text = KtoF(CtoK(temp1.Text));
                    temp2.Text = CtoK(temp1.Text);
                    unit3.Text = "F";
                }

            }

            if (unit1.SelectedIndex == 1)
            {

                if (unit2.SelectedIndex == 0)
                {
                    temp2.Text = KtoC(FtoK(temp1.Text));
                    temp3.Text = FtoK(temp1.Text);
                    unit3.Text = "K";
                }
                else if (unit2.SelectedIndex == 1)
                {
                    temp2.Text = temp1.Text;
                    temp3.Text = KtoC(FtoK(temp1.Text));
                    unit3.Text = "C";
                }
                else
                {
                    temp2.Text = FtoK(temp1.Text);
                    temp3.Text = KtoC(FtoK(temp1.Text));
                    unit3.Text = "C";
                }
            }

            if (unit1.SelectedIndex == 2)
            {

                if (unit2.SelectedIndex == 0)
                {
                    temp2.Text = KtoC(temp1.Text);
                    temp3.Text = KtoF(temp1.Text);
                    unit3.Text = "F";
                }
                else if (unit2.SelectedIndex == 1)
                {
                    temp2.Text = KtoF(temp1.Text);
                    temp3.Text = KtoC(temp1.Text);
                    unit3.Text = "C";
                }
                else
                {
                    temp2.Text = temp1.Text;
                    temp3.Text = KtoC(temp1.Text);
                    unit3.Text = "C";
                }
            }
        }

        private void update(object sender, EventArgs e)
        {
            button_Click(null, e);
        }

        private String CtoK(String c)
        {
            return Math.Round((Double.Parse(c) + 273.15),2).ToString();
        }

        private String FtoK(String f)
        {
            return CtoK(((Double.Parse(f) - 32) * 5 / 9).ToString());
        }

        private String KtoC(String k)
        {
            return Math.Round((Double.Parse(k) - 273.15),2).ToString();
        }

        private String KtoF(String k)
        {
            return Math.Round(((Double.Parse(KtoC(k)) * 9 / 5) + 32), 2).ToString();
        }

    }
}
