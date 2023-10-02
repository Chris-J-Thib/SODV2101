using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DialogDemo
{
    public partial class Form1 : Form
    {
        Form dialog = new Form();
        Button confBut = new Button();
        Button denBut = new Button();
        Label lblDialog = new Label();

        public Form1()
        {
            InitializeComponent();



            confBut.Text = "Confirm";
            denBut.Text = "Deny";
            lblDialog.Text = "Change background colour?";
            dialog.Text = "Change BGC?";
            lblDialog.AutoSize = true;
            confBut.Location = new Point(40, 40);
            denBut.Location = new Point(confBut.Width + confBut.Left + 5, confBut.Top);

            dialog.Controls.Add(denBut);
            dialog.Controls.Add(confBut);
            dialog.Controls.Add(lblDialog);
            dialog.AcceptButton = confBut;
            dialog.CancelButton = denBut;
        }

        private void action(object sender, EventArgs e)
        {
            dialog.ShowDialog();
        }
        private void confirm(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }
    }
}

