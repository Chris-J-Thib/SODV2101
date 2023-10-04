using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        //Class Objects and Variables
        const string fKey = "File";
        OpenFileDialog ofd = new OpenFileDialog();//open
        SaveFileDialog sfd = new SaveFileDialog();//save
        Form2 sPromt = new Form2();//save prompt form
        String curFilePath = null;//current file path
        String newFilePath = null;//current file path
        bool changed = false;//tracks if changes have been made.

        
        public Form1()
        {
            InitializeComponent();
            ofd.Filter = "txt files (*.txt)|*.txt";
            sfd.Filter = "txt files (*.txt)|*.txt";
            sfd.AddExtension = true;
            sfd.DefaultExt = ".txt";
            if (Environment.GetEnvironmentVariable(fKey) != null)
            {//if launched with variables, used for opening existing files
                curFilePath = Environment.GetEnvironmentVariable(fKey);//get the path
                rTB.Text = File.ReadAllText(curFilePath);
                this.Text = curFilePath.Split('\\').Last();
            }
        }

        /// <summary>
        /// Event handles clicking open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickOpen(object sender, EventArgs e)
        {
            switch (ofd.ShowDialog())
            {
                case DialogResult.OK:
                    newFilePath = ofd.FileName;
                    ClickNew(null, null);
                    break;
            }
        }

        /// <summary>
        /// Event handles clicking Save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickSave(object sender, EventArgs e)
        {
            if (curFilePath != null)
            {
                File.WriteAllText(curFilePath, rTB.Text);
                changed = false;
            } else
            {
                ClickSaveAs(null,null);
            }
        }

        /// <summary>
        /// Event handles clicking Save As
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickSaveAs(object sender, EventArgs e)
        {
            switch (sfd.ShowDialog())
            {
                case DialogResult.OK:
                    File.WriteAllText(sfd.FileName,rTB.Text);
                    curFilePath=sfd.FileName.Split('\\').Last();
                    this.Text= curFilePath;
                    changed = false;
                    break;
            }
        }

        /// <summary>
        /// Creates a new application, completely seperate from the old one.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickNew(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.Environment.Add(fKey, newFilePath);
            p.Start();
        }

        /// <summary>
        /// Event handles clicking Close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close(object sender, FormClosingEventArgs e)
        {
            if (!sPromt.IsDisposed && changed)//if not already closing or if there are changes
            {
                switch (sPromt.ShowDialog())//prompt to save
                {
                    case DialogResult.Yes ://save action is to save as
                        sPromt.Close();
                        ClickSaveAs(null,null);
                        Dispose();
                        break;
                    case DialogResult.No ://dont save
                        sPromt.Close();
                        Dispose();
                        break;
                    default: 
                        e.Cancel = true;//cancel / default
                        break;
                }
            }
        }

        /// <summary>
        /// Updates the text changed flag to ensure no loss of changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeFile(object sender, EventArgs e)
        {
            changed = true;
        }
    }
}
