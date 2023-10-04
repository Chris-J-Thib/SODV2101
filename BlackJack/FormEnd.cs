using System;
using System.Media;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class FormEnd : Form
    {
        public FormEnd(double highscore)
        {
            InitializeComponent();
            lblScore.Text = highscore.ToString("#,##0").Replace(".", ",");
            SystemSounds.Asterisk.Play();
        }

        private void FormEnd_Load(object sender, EventArgs e)
        {

        }
    }
}
