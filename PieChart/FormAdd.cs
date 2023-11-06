using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PieChart
{
    public partial class FormAdd : Form
    {
        public String type { get; set; }
        public String desc { get; set; }
        public String abrv { get; set; }

        public Color color { get; set; }

        public FormAdd()
        {
            InitializeComponent();
            DialogResult = DialogResult.No;
        }

        private void InitializeComponent()
        {
            this.textType = new System.Windows.Forms.TextBox();
            this.textAbrv = new System.Windows.Forms.TextBox();
            this.textDesc = new System.Windows.Forms.TextBox();
            this.panColor = new System.Windows.Forms.Panel();
            this.butAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textType
            // 
            this.textType.AccessibleName = "Type";
            this.textType.Location = new System.Drawing.Point(12, 12);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(100, 20);
            this.textType.TabIndex = 0;
            this.textType.Text = "Type";
            // 
            // textAbrv
            // 
            this.textAbrv.Location = new System.Drawing.Point(12, 38);
            this.textAbrv.Name = "textAbrv";
            this.textAbrv.Size = new System.Drawing.Size(100, 20);
            this.textAbrv.TabIndex = 1;
            this.textAbrv.Text = "Abbreviation";
            // 
            // textDesc
            // 
            this.textDesc.Location = new System.Drawing.Point(13, 65);
            this.textDesc.Name = "textDesc";
            this.textDesc.Size = new System.Drawing.Size(259, 20);
            this.textDesc.TabIndex = 2;
            this.textDesc.Text = "Description";
            // 
            // panColor
            // 
            this.panColor.BackColor = System.Drawing.Color.White;
            this.panColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panColor.Location = new System.Drawing.Point(118, 12);
            this.panColor.Name = "panColor";
            this.panColor.Size = new System.Drawing.Size(88, 46);
            this.panColor.TabIndex = 3;
            this.panColor.Click += new System.EventHandler(this.PickColor);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(12, 91);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(260, 23);
            this.butAdd.TabIndex = 4;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(60, 46);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Click to\r\nChange\r\nColour";
            this.textBox1.TextChanged += new System.EventHandler(this.PickColor);
            // 
            // FormAdd
            // 
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.panColor);
            this.Controls.Add(this.textDesc);
            this.Controls.Add(this.textAbrv);
            this.Controls.Add(this.textType);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Pie";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PickColor(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            panColor.BackColor = dlg.Color;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            if (textType.Text !=  "Type" &&
                textAbrv.Text != "Abbreviation")
            {
                type = textType.Text;
                abrv = textAbrv.Text;
                desc = textDesc.Text;
                color = panColor.BackColor;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
