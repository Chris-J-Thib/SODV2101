using System;
using System.Drawing;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class FormSave : Form
    {
        public FormSave()
        {
            InitializeComponent();
            init.Text = "???";
            init.BackColor = Color.White;
            init.ForeColor = Color.Gray;
        }

        private void FormSave_Load(object sender, EventArgs e)
        {

        }

        private void ClickSave(object sender, EventArgs e)
        {
            if (init.Text == "")
            {
                init.Text = "???";
            }
        }

        private void ChangeText(object sender, EventArgs e)
        {
            init.BackColor = Color.White;
            init.ForeColor = Color.Black;
        }
    }
}
