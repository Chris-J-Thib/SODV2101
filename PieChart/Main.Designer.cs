namespace PieChart
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.butApl = new System.Windows.Forms.Button();
            this.butLM = new System.Windows.Forms.Button();
            this.butCrm = new System.Windows.Forms.Button();
            this.butPI = new System.Windows.Forms.Button();
            this.butClr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butChoc = new System.Windows.Forms.Button();
            this.butChry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            chartArea2.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart.Legends.Add(legend2);
            this.Chart.Location = new System.Drawing.Point(250, 37);
            this.Chart.Name = "Chart";
            this.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Chart.Series.Add(series2);
            this.Chart.Size = new System.Drawing.Size(300, 300);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "Pie Chart";
            // 
            // butApl
            // 
            this.butApl.Location = new System.Drawing.Point(38, 364);
            this.butApl.Name = "butApl";
            this.butApl.Size = new System.Drawing.Size(80, 60);
            this.butApl.TabIndex = 1;
            this.butApl.Text = "Apple";
            this.butApl.UseVisualStyleBackColor = true;
            this.butApl.Click += new System.EventHandler(this.btnClicked);
            // 
            // butLM
            // 
            this.butLM.Location = new System.Drawing.Point(167, 364);
            this.butLM.Name = "butLM";
            this.butLM.Size = new System.Drawing.Size(80, 60);
            this.butLM.TabIndex = 2;
            this.butLM.Text = "Lemon Meringue";
            this.butLM.UseVisualStyleBackColor = true;
            this.butLM.Click += new System.EventHandler(this.btnClicked);
            // 
            // butCrm
            // 
            this.butCrm.Location = new System.Drawing.Point(296, 364);
            this.butCrm.Name = "butCrm";
            this.butCrm.Size = new System.Drawing.Size(80, 60);
            this.butCrm.TabIndex = 3;
            this.butCrm.Text = "Cream";
            this.butCrm.UseVisualStyleBackColor = true;
            this.butCrm.Click += new System.EventHandler(this.btnClicked);
            // 
            // butPI
            // 
            this.butPI.Location = new System.Drawing.Point(683, 364);
            this.butPI.Name = "butPI";
            this.butPI.Size = new System.Drawing.Size(80, 60);
            this.butPI.TabIndex = 4;
            this.butPI.Text = "Math";
            this.butPI.UseVisualStyleBackColor = true;
            this.butPI.Click += new System.EventHandler(this.btnClicked);
            // 
            // butClr
            // 
            this.butClr.Location = new System.Drawing.Point(624, 174);
            this.butClr.Name = "butClr";
            this.butClr.Size = new System.Drawing.Size(80, 60);
            this.butClr.TabIndex = 5;
            this.butClr.Text = "Clear";
            this.butClr.UseVisualStyleBackColor = true;
            this.butClr.Click += new System.EventHandler(this.btnClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Favourite Types of Pie";
            // 
            // butChoc
            // 
            this.butChoc.Location = new System.Drawing.Point(554, 364);
            this.butChoc.Name = "butChoc";
            this.butChoc.Size = new System.Drawing.Size(80, 60);
            this.butChoc.TabIndex = 7;
            this.butChoc.Text = "Chocolate";
            this.butChoc.UseVisualStyleBackColor = true;
            this.butChoc.Click += new System.EventHandler(this.btnClicked);
            // 
            // butChry
            // 
            this.butChry.Location = new System.Drawing.Point(425, 364);
            this.butChry.Name = "butChry";
            this.butChry.Size = new System.Drawing.Size(80, 60);
            this.butChry.TabIndex = 8;
            this.butChry.Text = "Cherry";
            this.butChry.UseVisualStyleBackColor = true;
            this.butChry.Click += new System.EventHandler(this.btnClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butChry);
            this.Controls.Add(this.butChoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butClr);
            this.Controls.Add(this.butPI);
            this.Controls.Add(this.butCrm);
            this.Controls.Add(this.butLM);
            this.Controls.Add(this.butApl);
            this.Controls.Add(this.Chart);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button butApl;
        private System.Windows.Forms.Button butLM;
        private System.Windows.Forms.Button butCrm;
        private System.Windows.Forms.Button butPI;
        private System.Windows.Forms.Button butClr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butChoc;
        private System.Windows.Forms.Button butChry;
    }
}

