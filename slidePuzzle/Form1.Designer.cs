namespace slidePuzzle
{
    partial class Form1
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
            this.grid = new System.Windows.Forms.TableLayoutPanel();
            this.butShuf = new System.Windows.Forms.Button();
            this.butSolve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grid.ColumnCount = 3;
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.grid.Location = new System.Drawing.Point(192, 89);
            this.grid.Name = "grid";
            this.grid.RowCount = 3;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.grid.Size = new System.Drawing.Size(300, 300);
            this.grid.TabIndex = 1;
            // 
            // butShuf
            // 
            this.butShuf.Location = new System.Drawing.Point(192, 423);
            this.butShuf.Name = "butShuf";
            this.butShuf.Size = new System.Drawing.Size(95, 48);
            this.butShuf.TabIndex = 2;
            this.butShuf.Text = "Shuffle";
            this.butShuf.UseVisualStyleBackColor = true;
            // 
            // butSolve
            // 
            this.butSolve.Location = new System.Drawing.Point(397, 423);
            this.butSolve.Name = "butSolve";
            this.butSolve.Size = new System.Drawing.Size(95, 48);
            this.butSolve.TabIndex = 3;
            this.butSolve.Text = "Solve";
            this.butSolve.UseVisualStyleBackColor = true;
            this.butSolve.Click += new System.EventHandler(this.ClickSolve);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.butSolve);
            this.Controls.Add(this.butShuf);
            this.Controls.Add(this.grid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.ClickShuffle);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel grid;
        private System.Windows.Forms.Button butShuf;
        private System.Windows.Forms.Button butSolve;
    }
}

