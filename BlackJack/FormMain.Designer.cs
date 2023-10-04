namespace BlackJack
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.funds = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.butHold = new System.Windows.Forms.Button();
            this.butHit = new System.Windows.Forms.Button();
            this.betAll = new System.Windows.Forms.RadioButton();
            this.betMin = new System.Windows.Forms.RadioButton();
            this.fieldPlay = new System.Windows.Forms.TableLayoutPanel();
            this.cardsPlayer = new System.Windows.Forms.FlowLayoutPanel();
            this.fieldCount = new System.Windows.Forms.TableLayoutPanel();
            this.lblCntPlr = new System.Windows.Forms.Label();
            this.lblCntDlr = new System.Windows.Forms.Label();
            this.cntPlr = new System.Windows.Forms.Label();
            this.cntDlr = new System.Windows.Forms.Label();
            this.cardsDealer = new System.Windows.Forms.FlowLayoutPanel();
            this.prvRnds = new System.Windows.Forms.ListBox();
            this.lblRounds = new System.Windows.Forms.Label();
            this.butStart = new System.Windows.Forms.Button();
            this.betHalf = new System.Windows.Forms.RadioButton();
            this.lblActiveBet = new System.Windows.Forms.Label();
            this.butQuit = new System.Windows.Forms.Button();
            this.lblldrbrd = new System.Windows.Forms.Label();
            this.ldrbrd = new System.Windows.Forms.TableLayoutPanel();
            this.lblCS = new System.Windows.Forms.Label();
            this.scoreCurrent = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.unitSymbol = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.butSFX = new System.Windows.Forms.Button();
            this.butMusic = new System.Windows.Forms.Button();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.fieldPlay.SuspendLayout();
            this.fieldCount.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // funds
            // 
            this.funds.AutoSize = true;
            this.funds.BackColor = System.Drawing.Color.Gold;
            this.funds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funds.Location = new System.Drawing.Point(15, 15);
            this.funds.MinimumSize = new System.Drawing.Size(90, 30);
            this.funds.Name = "funds";
            this.funds.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.funds.Size = new System.Drawing.Size(90, 30);
            this.funds.TabIndex = 0;
            this.funds.Text = "temp";
            this.funds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBet
            // 
            this.lblBet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblBet.AutoSize = true;
            this.lblBet.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Location = new System.Drawing.Point(132, 0);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(31, 30);
            this.lblBet.TabIndex = 6;
            this.lblBet.Text = "BET";
            this.lblBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butHold
            // 
            this.butHold.BackColor = System.Drawing.Color.DarkGray;
            this.butHold.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butHold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butHold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.butHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butHold.ForeColor = System.Drawing.Color.Black;
            this.butHold.Location = new System.Drawing.Point(225, 281);
            this.butHold.Name = "butHold";
            this.butHold.Size = new System.Drawing.Size(75, 23);
            this.butHold.TabIndex = 2;
            this.butHold.Text = "Hold";
            this.butHold.UseVisualStyleBackColor = false;
            this.butHold.Visible = false;
            this.butHold.Click += new System.EventHandler(this.ClickHold);
            // 
            // butHit
            // 
            this.butHit.BackColor = System.Drawing.Color.LightCoral;
            this.butHit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butHit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butHit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.butHit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.butHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butHit.Location = new System.Drawing.Point(129, 281);
            this.butHit.Name = "butHit";
            this.butHit.Size = new System.Drawing.Size(75, 23);
            this.butHit.TabIndex = 1;
            this.butHit.Text = "Hit";
            this.butHit.UseVisualStyleBackColor = false;
            this.butHit.Visible = false;
            this.butHit.Click += new System.EventHandler(this.ClickHit);
            // 
            // betAll
            // 
            this.betAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.betAll.AutoSize = true;
            this.betAll.BackColor = System.Drawing.Color.Honeydew;
            this.betAll.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.betAll.Location = new System.Drawing.Point(209, 53);
            this.betAll.MinimumSize = new System.Drawing.Size(60, 40);
            this.betAll.Name = "betAll";
            this.betAll.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.betAll.Size = new System.Drawing.Size(60, 40);
            this.betAll.TabIndex = 9;
            this.betAll.Text = "All In($)";
            this.betAll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.betAll.UseVisualStyleBackColor = false;
            // 
            // betMin
            // 
            this.betMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.betMin.AutoSize = true;
            this.betMin.BackColor = System.Drawing.Color.Honeydew;
            this.betMin.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.betMin.Checked = true;
            this.betMin.Location = new System.Drawing.Point(27, 53);
            this.betMin.MinimumSize = new System.Drawing.Size(60, 40);
            this.betMin.Name = "betMin";
            this.betMin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.betMin.Size = new System.Drawing.Size(60, 40);
            this.betMin.TabIndex = 8;
            this.betMin.TabStop = true;
            this.betMin.Text = "Min($)";
            this.betMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.betMin.UseVisualStyleBackColor = false;
            // 
            // fieldPlay
            // 
            this.fieldPlay.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.fieldPlay.ColumnCount = 1;
            this.fieldPlay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fieldPlay.Controls.Add(this.cardsPlayer, 0, 2);
            this.fieldPlay.Controls.Add(this.fieldCount, 0, 1);
            this.fieldPlay.Controls.Add(this.cardsDealer, 0, 0);
            this.fieldPlay.Location = new System.Drawing.Point(114, 21);
            this.fieldPlay.Name = "fieldPlay";
            this.fieldPlay.RowCount = 3;
            this.fieldPlay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.fieldPlay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.fieldPlay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.fieldPlay.Size = new System.Drawing.Size(200, 242);
            this.fieldPlay.TabIndex = 10;
            // 
            // cardsPlayer
            // 
            this.cardsPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardsPlayer.AutoSize = true;
            this.cardsPlayer.Location = new System.Drawing.Point(95, 196);
            this.cardsPlayer.Name = "cardsPlayer";
            this.cardsPlayer.Padding = new System.Windows.Forms.Padding(5);
            this.cardsPlayer.Size = new System.Drawing.Size(10, 10);
            this.cardsPlayer.TabIndex = 4;
            // 
            // fieldCount
            // 
            this.fieldCount.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.fieldCount.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.fieldCount.ColumnCount = 2;
            this.fieldCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fieldCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fieldCount.Controls.Add(this.lblCntPlr, 0, 0);
            this.fieldCount.Controls.Add(this.lblCntDlr, 1, 0);
            this.fieldCount.Controls.Add(this.cntPlr, 0, 1);
            this.fieldCount.Controls.Add(this.cntDlr, 1, 1);
            this.fieldCount.Location = new System.Drawing.Point(4, 84);
            this.fieldCount.Name = "fieldCount";
            this.fieldCount.RowCount = 2;
            this.fieldCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.fieldCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.fieldCount.Size = new System.Drawing.Size(192, 73);
            this.fieldCount.TabIndex = 0;
            // 
            // lblCntPlr
            // 
            this.lblCntPlr.AutoSize = true;
            this.lblCntPlr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCntPlr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCntPlr.Location = new System.Drawing.Point(4, 1);
            this.lblCntPlr.Name = "lblCntPlr";
            this.lblCntPlr.Size = new System.Drawing.Size(88, 17);
            this.lblCntPlr.TabIndex = 0;
            this.lblCntPlr.Text = "Your Count";
            this.lblCntPlr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCntDlr
            // 
            this.lblCntDlr.AutoSize = true;
            this.lblCntDlr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCntDlr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCntDlr.Location = new System.Drawing.Point(99, 1);
            this.lblCntDlr.Name = "lblCntDlr";
            this.lblCntDlr.Size = new System.Drawing.Size(89, 17);
            this.lblCntDlr.TabIndex = 1;
            this.lblCntDlr.Text = "Dealer Count";
            this.lblCntDlr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cntPlr
            // 
            this.cntPlr.AutoSize = true;
            this.cntPlr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntPlr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntPlr.Location = new System.Drawing.Point(4, 19);
            this.cntPlr.Name = "cntPlr";
            this.cntPlr.Size = new System.Drawing.Size(88, 53);
            this.cntPlr.TabIndex = 2;
            this.cntPlr.Text = "0";
            this.cntPlr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cntDlr
            // 
            this.cntDlr.AutoSize = true;
            this.cntDlr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntDlr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntDlr.Location = new System.Drawing.Point(99, 19);
            this.cntDlr.Name = "cntDlr";
            this.cntDlr.Size = new System.Drawing.Size(89, 53);
            this.cntDlr.TabIndex = 3;
            this.cntDlr.Text = "0";
            this.cntDlr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardsDealer
            // 
            this.cardsDealer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardsDealer.AutoSize = true;
            this.cardsDealer.Location = new System.Drawing.Point(95, 35);
            this.cardsDealer.Name = "cardsDealer";
            this.cardsDealer.Padding = new System.Windows.Forms.Padding(5);
            this.cardsDealer.Size = new System.Drawing.Size(10, 10);
            this.cardsDealer.TabIndex = 3;
            // 
            // prvRnds
            // 
            this.prvRnds.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.prvRnds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prvRnds.ForeColor = System.Drawing.SystemColors.WindowText;
            this.prvRnds.FormattingEnabled = true;
            this.prvRnds.Location = new System.Drawing.Point(15, 85);
            this.prvRnds.Name = "prvRnds";
            this.prvRnds.ScrollAlwaysVisible = true;
            this.prvRnds.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.prvRnds.Size = new System.Drawing.Size(90, 221);
            this.prvRnds.TabIndex = 11;
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRounds.Location = new System.Drawing.Point(15, 56);
            this.lblRounds.MinimumSize = new System.Drawing.Size(90, 30);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(90, 30);
            this.lblRounds.TabIndex = 12;
            this.lblRounds.Text = "Last Rounds";
            this.lblRounds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butStart
            // 
            this.butStart.BackColor = System.Drawing.Color.Lime;
            this.butStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.butStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butStart.ForeColor = System.Drawing.Color.Black;
            this.butStart.Location = new System.Drawing.Point(129, 281);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(75, 23);
            this.butStart.TabIndex = 14;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = false;
            this.butStart.Click += new System.EventHandler(this.ClickStart);
            // 
            // betHalf
            // 
            this.betHalf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.betHalf.AutoSize = true;
            this.betHalf.BackColor = System.Drawing.Color.Honeydew;
            this.betHalf.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.betHalf.Location = new System.Drawing.Point(118, 53);
            this.betHalf.MinimumSize = new System.Drawing.Size(60, 40);
            this.betHalf.Name = "betHalf";
            this.betHalf.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.betHalf.Size = new System.Drawing.Size(60, 40);
            this.betHalf.TabIndex = 7;
            this.betHalf.Text = "Half($)";
            this.betHalf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.betHalf.UseVisualStyleBackColor = false;
            // 
            // lblActiveBet
            // 
            this.lblActiveBet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblActiveBet.AutoSize = true;
            this.lblActiveBet.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblActiveBet.ForeColor = System.Drawing.Color.Black;
            this.lblActiveBet.Location = new System.Drawing.Point(118, 30);
            this.lblActiveBet.Margin = new System.Windows.Forms.Padding(0);
            this.lblActiveBet.Name = "lblActiveBet";
            this.lblActiveBet.Size = new System.Drawing.Size(60, 20);
            this.lblActiveBet.TabIndex = 15;
            this.lblActiveBet.Text = "amount bet";
            this.lblActiveBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblActiveBet.Visible = false;
            // 
            // butQuit
            // 
            this.butQuit.BackColor = System.Drawing.Color.Red;
            this.butQuit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.butQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.butQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butQuit.ForeColor = System.Drawing.Color.Black;
            this.butQuit.Location = new System.Drawing.Point(225, 281);
            this.butQuit.Name = "butQuit";
            this.butQuit.Size = new System.Drawing.Size(75, 23);
            this.butQuit.TabIndex = 16;
            this.butQuit.Text = "Quit";
            this.butQuit.UseVisualStyleBackColor = false;
            this.butQuit.Click += new System.EventHandler(this.ClickQuit);
            // 
            // lblldrbrd
            // 
            this.lblldrbrd.AutoSize = true;
            this.lblldrbrd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblldrbrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblldrbrd.Location = new System.Drawing.Point(322, 15);
            this.lblldrbrd.Name = "lblldrbrd";
            this.lblldrbrd.Padding = new System.Windows.Forms.Padding(10, 10, 10, 257);
            this.lblldrbrd.Size = new System.Drawing.Size(98, 280);
            this.lblldrbrd.TabIndex = 18;
            this.lblldrbrd.Text = "Leaderboard\r\n";
            this.lblldrbrd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ldrbrd
            // 
            this.ldrbrd.AutoSize = true;
            this.ldrbrd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ldrbrd.ColumnCount = 3;
            this.ldrbrd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ldrbrd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ldrbrd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ldrbrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldrbrd.Location = new System.Drawing.Point(322, 53);
            this.ldrbrd.Margin = new System.Windows.Forms.Padding(0);
            this.ldrbrd.Name = "ldrbrd";
            this.ldrbrd.RowCount = 10;
            this.ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.ldrbrd.Size = new System.Drawing.Size(97, 215);
            this.ldrbrd.TabIndex = 19;
            // 
            // lblCS
            // 
            this.lblCS.AutoSize = true;
            this.lblCS.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCS.Location = new System.Drawing.Point(328, 244);
            this.lblCS.Name = "lblCS";
            this.lblCS.Size = new System.Drawing.Size(85, 13);
            this.lblCS.TabIndex = 20;
            this.lblCS.Text = "Current Score";
            // 
            // scoreCurrent
            // 
            this.scoreCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.scoreCurrent.AutoSize = true;
            this.scoreCurrent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.scoreCurrent.Location = new System.Drawing.Point(34, 0);
            this.scoreCurrent.Name = "scoreCurrent";
            this.scoreCurrent.Size = new System.Drawing.Size(30, 54);
            this.scoreCurrent.TabIndex = 21;
            this.scoreCurrent.Text = "temp";
            this.scoreCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblActiveBet, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.betMin, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.betHalf, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.betAll, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBet, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(67, 329);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(297, 100);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.scoreCurrent, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(322, 254);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(98, 54);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // unitSymbol
            // 
            this.unitSymbol.AutoSize = true;
            this.unitSymbol.BackColor = System.Drawing.Color.Gold;
            this.unitSymbol.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitSymbol.Location = new System.Drawing.Point(15, 20);
            this.unitSymbol.Name = "unitSymbol";
            this.unitSymbol.Size = new System.Drawing.Size(19, 20);
            this.unitSymbol.TabIndex = 25;
            this.unitSymbol.Text = "$";
            // 
            // butSFX
            // 
            this.butSFX.BackColor = System.Drawing.Color.SkyBlue;
            this.butSFX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSFX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSFX.Location = new System.Drawing.Point(19, 329);
            this.butSFX.Name = "butSFX";
            this.butSFX.Size = new System.Drawing.Size(30, 35);
            this.butSFX.TabIndex = 26;
            this.butSFX.Text = "🔊";
            this.butSFX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butSFX.UseVisualStyleBackColor = false;
            this.butSFX.Click += new System.EventHandler(this.ClickSFX);
            // 
            // butMusic
            // 
            this.butMusic.BackColor = System.Drawing.Color.SkyBlue;
            this.butMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMusic.Location = new System.Drawing.Point(19, 394);
            this.butMusic.Name = "butMusic";
            this.butMusic.Size = new System.Drawing.Size(30, 35);
            this.butMusic.TabIndex = 27;
            this.butMusic.Text = "🎵";
            this.butMusic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butMusic.UseVisualStyleBackColor = false;
            this.butMusic.Click += new System.EventHandler(this.ClickMusic);
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(111, -17);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(211, 32);
            this.WMP.TabIndex = 29;
            this.WMP.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(429, 451);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.butMusic);
            this.Controls.Add(this.butSFX);
            this.Controls.Add(this.lblCS);
            this.Controls.Add(this.unitSymbol);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.ldrbrd);
            this.Controls.Add(this.lblldrbrd);
            this.Controls.Add(this.butQuit);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.lblRounds);
            this.Controls.Add(this.prvRnds);
            this.Controls.Add(this.fieldPlay);
            this.Controls.Add(this.butHold);
            this.Controls.Add(this.butHit);
            this.Controls.Add(this.funds);
            this.Controls.Add(this.tableLayoutPanel1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 50);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(445, 490);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(445, 490);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black Jack";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.ClickHelp);
            this.Load += new System.EventHandler(this.FormLoad);
            this.fieldPlay.ResumeLayout(false);
            this.fieldPlay.PerformLayout();
            this.fieldCount.ResumeLayout(false);
            this.fieldCount.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label funds;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Button butHold;
        private System.Windows.Forms.Button butHit;
        private System.Windows.Forms.RadioButton betAll;
        private System.Windows.Forms.RadioButton betMin;
        private System.Windows.Forms.TableLayoutPanel fieldPlay;
        private System.Windows.Forms.TableLayoutPanel fieldCount;
        private System.Windows.Forms.Label lblCntPlr;
        private System.Windows.Forms.Label lblCntDlr;
        private System.Windows.Forms.ListBox prvRnds;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.FlowLayoutPanel cardsDealer;
        private System.Windows.Forms.FlowLayoutPanel cardsPlayer;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Label cntPlr;
        private System.Windows.Forms.Label cntDlr;
        private System.Windows.Forms.RadioButton betHalf;
        private System.Windows.Forms.Label lblActiveBet;
        private System.Windows.Forms.Button butQuit;
        private System.Windows.Forms.Label lblldrbrd;
        private System.Windows.Forms.TableLayoutPanel ldrbrd;
        private System.Windows.Forms.Label lblCS;
        private System.Windows.Forms.Label scoreCurrent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label unitSymbol;
        private System.Windows.Forms.Button butSFX;
        private System.Windows.Forms.Button butMusic;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
    }
}

