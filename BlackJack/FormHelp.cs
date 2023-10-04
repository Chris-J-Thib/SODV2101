using System;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();

        }

        private void FormHelp_Load(object sender, EventArgs e)
        {

        }

        private void ClickLink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Chris-J-Thib/SODV2101/blob/b7e4d4e4d5e9a2832030563f4e1b3fa2a8d3208f/BlackJack/Credits");
        }
    }
}
