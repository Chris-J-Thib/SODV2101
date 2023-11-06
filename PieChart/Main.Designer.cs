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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listPies = new System.Windows.Forms.FlowLayoutPanel();
            this.butAdd = new System.Windows.Forms.Button();
            this.butRst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            this.Chart.BorderlineColor = System.Drawing.Color.Black;
            this.Chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 55F;
            chartArea4.Position.Width = 80F;
            chartArea4.Position.X = 10F;
            chartArea4.Position.Y = 38F;
            this.Chart.ChartAreas.Add(chartArea4);
            legend4.BorderColor = System.Drawing.Color.Transparent;
            legend4.Name = "Legend1";
            legend4.Position.Auto = false;
            legend4.Position.Height = 22.07358F;
            legend4.Position.Width = 44.48161F;
            legend4.Position.X = 9F;
            legend4.Position.Y = 3F;
            this.Chart.Legends.Add(legend4);
            this.Chart.Location = new System.Drawing.Point(402, 0);
            this.Chart.Name = "Chart";
            this.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "PieChart";
            this.Chart.Series.Add(series4);
            this.Chart.Size = new System.Drawing.Size(460, 460);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "Pie Chart";
            // 
            // listPies
            // 
            this.listPies.BackColor = System.Drawing.Color.White;
            this.listPies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPies.Location = new System.Drawing.Point(0, 79);
            this.listPies.Name = "listPies";
            this.listPies.Size = new System.Drawing.Size(402, 306);
            this.listPies.TabIndex = 6;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(8, 394);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(190, 60);
            this.butAdd.TabIndex = 7;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.btnClicked);
            // 
            // butRst
            // 
            this.butRst.Location = new System.Drawing.Point(205, 394);
            this.butRst.Name = "butRst";
            this.butRst.Size = new System.Drawing.Size(190, 60);
            this.butRst.TabIndex = 8;
            this.butRst.Text = "Reset";
            this.butRst.UseVisualStyleBackColor = true;
            this.butRst.Click += new System.EventHandler(this.Main_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hover Over For More Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Click Type To Count Your Fav";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butRst);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.listPies);
            this.Controls.Add(this.Chart);
            this.Name = "Main";
            this.Text = "Favourite Pies";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel listPies;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butRst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

