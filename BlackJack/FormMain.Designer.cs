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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            funds = new System.Windows.Forms.Label();
            lblBet = new System.Windows.Forms.Label();
            butHold = new System.Windows.Forms.Button();
            butHit = new System.Windows.Forms.Button();
            betAll = new System.Windows.Forms.RadioButton();
            betMin = new System.Windows.Forms.RadioButton();
            fieldPlay = new System.Windows.Forms.TableLayoutPanel();
            cardsPlayer = new System.Windows.Forms.FlowLayoutPanel();
            fieldCount = new System.Windows.Forms.TableLayoutPanel();
            lblCntPlr = new System.Windows.Forms.Label();
            lblCntDlr = new System.Windows.Forms.Label();
            cntPlr = new System.Windows.Forms.Label();
            cntDlr = new System.Windows.Forms.Label();
            cardsDealer = new System.Windows.Forms.FlowLayoutPanel();
            prvRnds = new System.Windows.Forms.ListBox();
            lblRounds = new System.Windows.Forms.Label();
            butStart = new System.Windows.Forms.Button();
            betHalf = new System.Windows.Forms.RadioButton();
            lblActiveBet = new System.Windows.Forms.Label();
            butQuit = new System.Windows.Forms.Button();
            lblldrbrd = new System.Windows.Forms.Label();
            ldrbrd = new System.Windows.Forms.TableLayoutPanel();
            lblCS = new System.Windows.Forms.Label();
            scoreCurrent = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            unitSymbol = new System.Windows.Forms.Label();
            bindingSource1 = new System.Windows.Forms.BindingSource(components);
            butSFX = new System.Windows.Forms.Button();
            butMusic = new System.Windows.Forms.Button();
            WMP = new AxWMPLib.AxWindowsMediaPlayer();
            fieldPlay.SuspendLayout();
            fieldCount.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WMP).BeginInit();
            SuspendLayout();
            // 
            // funds
            // 
            funds.AutoSize = true;
            funds.BackColor = System.Drawing.Color.Gold;
            funds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            funds.Location = new System.Drawing.Point(18, 17);
            funds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            funds.MinimumSize = new System.Drawing.Size(105, 35);
            funds.Name = "funds";
            funds.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            funds.Size = new System.Drawing.Size(105, 35);
            funds.TabIndex = 0;
            funds.Text = "temp";
            funds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBet
            // 
            lblBet.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            lblBet.AutoSize = true;
            lblBet.BackColor = System.Drawing.Color.MediumSeaGreen;
            lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblBet.Location = new System.Drawing.Point(157, 0);
            lblBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBet.Name = "lblBet";
            lblBet.Size = new System.Drawing.Size(31, 34);
            lblBet.TabIndex = 6;
            lblBet.Text = "BET";
            lblBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butHold
            // 
            butHold.BackColor = System.Drawing.Color.DarkGray;
            butHold.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            butHold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            butHold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            butHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            butHold.ForeColor = System.Drawing.Color.Black;
            butHold.Location = new System.Drawing.Point(262, 324);
            butHold.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            butHold.Name = "butHold";
            butHold.Size = new System.Drawing.Size(88, 27);
            butHold.TabIndex = 2;
            butHold.Text = "Hold";
            butHold.UseVisualStyleBackColor = false;
            butHold.Visible = false;
            butHold.Click += ClickHold;
            // 
            // butHit
            // 
            butHit.BackColor = System.Drawing.Color.LightCoral;
            butHit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            butHit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            butHit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            butHit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            butHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            butHit.Location = new System.Drawing.Point(150, 324);
            butHit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            butHit.Name = "butHit";
            butHit.Size = new System.Drawing.Size(88, 27);
            butHit.TabIndex = 1;
            butHit.Text = "Hit";
            butHit.UseVisualStyleBackColor = false;
            butHit.Visible = false;
            butHit.Click += ClickHit;
            // 
            // betAll
            // 
            betAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            betAll.AutoSize = true;
            betAll.BackColor = System.Drawing.Color.Honeydew;
            betAll.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            betAll.Location = new System.Drawing.Point(244, 60);
            betAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            betAll.MinimumSize = new System.Drawing.Size(70, 46);
            betAll.Name = "betAll";
            betAll.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            betAll.Size = new System.Drawing.Size(70, 46);
            betAll.TabIndex = 9;
            betAll.Text = "All In($)";
            betAll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            betAll.UseVisualStyleBackColor = false;
            // 
            // betMin
            // 
            betMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            betMin.AutoSize = true;
            betMin.BackColor = System.Drawing.Color.Honeydew;
            betMin.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            betMin.Checked = true;
            betMin.Location = new System.Drawing.Point(32, 60);
            betMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            betMin.MinimumSize = new System.Drawing.Size(70, 46);
            betMin.Name = "betMin";
            betMin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            betMin.Size = new System.Drawing.Size(70, 46);
            betMin.TabIndex = 8;
            betMin.TabStop = true;
            betMin.Text = "Min($)";
            betMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            betMin.UseVisualStyleBackColor = false;
            // 
            // fieldPlay
            // 
            fieldPlay.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            fieldPlay.ColumnCount = 1;
            fieldPlay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            fieldPlay.Controls.Add(cardsPlayer, 0, 2);
            fieldPlay.Controls.Add(fieldCount, 0, 1);
            fieldPlay.Controls.Add(cardsDealer, 0, 0);
            fieldPlay.Location = new System.Drawing.Point(133, 24);
            fieldPlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            fieldPlay.Name = "fieldPlay";
            fieldPlay.RowCount = 3;
            fieldPlay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            fieldPlay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            fieldPlay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            fieldPlay.Size = new System.Drawing.Size(233, 279);
            fieldPlay.TabIndex = 10;
            // 
            // cardsPlayer
            // 
            cardsPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            cardsPlayer.AutoSize = true;
            cardsPlayer.Location = new System.Drawing.Point(110, 225);
            cardsPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cardsPlayer.Name = "cardsPlayer";
            cardsPlayer.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            cardsPlayer.Size = new System.Drawing.Size(12, 12);
            cardsPlayer.TabIndex = 4;
            // 
            // fieldCount
            // 
            fieldCount.BackColor = System.Drawing.Color.MediumSeaGreen;
            fieldCount.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            fieldCount.ColumnCount = 2;
            fieldCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            fieldCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            fieldCount.Controls.Add(lblCntPlr, 0, 0);
            fieldCount.Controls.Add(lblCntDlr, 1, 0);
            fieldCount.Controls.Add(cntPlr, 0, 1);
            fieldCount.Controls.Add(cntDlr, 1, 1);
            fieldCount.Location = new System.Drawing.Point(5, 96);
            fieldCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            fieldCount.Name = "fieldCount";
            fieldCount.RowCount = 2;
            fieldCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            fieldCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            fieldCount.Size = new System.Drawing.Size(223, 84);
            fieldCount.TabIndex = 0;
            // 
            // lblCntPlr
            // 
            lblCntPlr.AutoSize = true;
            lblCntPlr.Dock = System.Windows.Forms.DockStyle.Fill;
            lblCntPlr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            lblCntPlr.Location = new System.Drawing.Point(5, 1);
            lblCntPlr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCntPlr.Name = "lblCntPlr";
            lblCntPlr.Size = new System.Drawing.Size(102, 20);
            lblCntPlr.TabIndex = 0;
            lblCntPlr.Text = "Your Count";
            lblCntPlr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCntDlr
            // 
            lblCntDlr.AutoSize = true;
            lblCntDlr.Dock = System.Windows.Forms.DockStyle.Fill;
            lblCntDlr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            lblCntDlr.Location = new System.Drawing.Point(116, 1);
            lblCntDlr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCntDlr.Name = "lblCntDlr";
            lblCntDlr.Size = new System.Drawing.Size(102, 20);
            lblCntDlr.TabIndex = 1;
            lblCntDlr.Text = "Dealer Count";
            lblCntDlr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cntPlr
            // 
            cntPlr.AutoSize = true;
            cntPlr.Dock = System.Windows.Forms.DockStyle.Fill;
            cntPlr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cntPlr.Location = new System.Drawing.Point(5, 22);
            cntPlr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cntPlr.Name = "cntPlr";
            cntPlr.Size = new System.Drawing.Size(102, 61);
            cntPlr.TabIndex = 2;
            cntPlr.Text = "0";
            cntPlr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cntDlr
            // 
            cntDlr.AutoSize = true;
            cntDlr.Dock = System.Windows.Forms.DockStyle.Fill;
            cntDlr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            cntDlr.Location = new System.Drawing.Point(116, 22);
            cntDlr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cntDlr.Name = "cntDlr";
            cntDlr.Size = new System.Drawing.Size(102, 61);
            cntDlr.TabIndex = 3;
            cntDlr.Text = "0";
            cntDlr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardsDealer
            // 
            cardsDealer.Anchor = System.Windows.Forms.AnchorStyles.None;
            cardsDealer.AutoSize = true;
            cardsDealer.Location = new System.Drawing.Point(110, 40);
            cardsDealer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cardsDealer.Name = "cardsDealer";
            cardsDealer.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            cardsDealer.Size = new System.Drawing.Size(12, 12);
            cardsDealer.TabIndex = 3;
            // 
            // prvRnds
            // 
            prvRnds.BackColor = System.Drawing.Color.MediumSeaGreen;
            prvRnds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            prvRnds.ForeColor = System.Drawing.SystemColors.WindowText;
            prvRnds.FormattingEnabled = true;
            prvRnds.ItemHeight = 15;
            prvRnds.Location = new System.Drawing.Point(18, 98);
            prvRnds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            prvRnds.Name = "prvRnds";
            prvRnds.ScrollAlwaysVisible = true;
            prvRnds.SelectionMode = System.Windows.Forms.SelectionMode.None;
            prvRnds.Size = new System.Drawing.Size(105, 255);
            prvRnds.TabIndex = 11;
            // 
            // lblRounds
            // 
            lblRounds.AutoSize = true;
            lblRounds.BackColor = System.Drawing.Color.MediumSeaGreen;
            lblRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            lblRounds.Location = new System.Drawing.Point(18, 65);
            lblRounds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRounds.MinimumSize = new System.Drawing.Size(105, 35);
            lblRounds.Name = "lblRounds";
            lblRounds.Size = new System.Drawing.Size(105, 35);
            lblRounds.TabIndex = 12;
            lblRounds.Text = "Last Rounds";
            lblRounds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butStart
            // 
            butStart.BackColor = System.Drawing.Color.Lime;
            butStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            butStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            butStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            butStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            butStart.ForeColor = System.Drawing.Color.Black;
            butStart.Location = new System.Drawing.Point(150, 324);
            butStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            butStart.Name = "butStart";
            butStart.Size = new System.Drawing.Size(88, 27);
            butStart.TabIndex = 14;
            butStart.Text = "Start";
            butStart.UseVisualStyleBackColor = false;
            butStart.Click += ClickStart;
            // 
            // betHalf
            // 
            betHalf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            betHalf.AutoSize = true;
            betHalf.BackColor = System.Drawing.Color.Honeydew;
            betHalf.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            betHalf.Location = new System.Drawing.Point(138, 60);
            betHalf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            betHalf.MinimumSize = new System.Drawing.Size(70, 46);
            betHalf.Name = "betHalf";
            betHalf.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            betHalf.Size = new System.Drawing.Size(70, 46);
            betHalf.TabIndex = 7;
            betHalf.Text = "Half($)";
            betHalf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            betHalf.UseVisualStyleBackColor = false;
            // 
            // lblActiveBet
            // 
            lblActiveBet.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            lblActiveBet.AutoSize = true;
            lblActiveBet.BackColor = System.Drawing.Color.MediumSeaGreen;
            lblActiveBet.ForeColor = System.Drawing.Color.Black;
            lblActiveBet.Location = new System.Drawing.Point(138, 34);
            lblActiveBet.Margin = new System.Windows.Forms.Padding(0);
            lblActiveBet.Name = "lblActiveBet";
            lblActiveBet.Size = new System.Drawing.Size(69, 23);
            lblActiveBet.TabIndex = 15;
            lblActiveBet.Text = "amount bet";
            lblActiveBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblActiveBet.Visible = false;
            // 
            // butQuit
            // 
            butQuit.BackColor = System.Drawing.Color.Red;
            butQuit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            butQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            butQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            butQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            butQuit.ForeColor = System.Drawing.Color.Black;
            butQuit.Location = new System.Drawing.Point(262, 324);
            butQuit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            butQuit.Name = "butQuit";
            butQuit.Size = new System.Drawing.Size(88, 27);
            butQuit.TabIndex = 16;
            butQuit.Text = "Quit";
            butQuit.UseVisualStyleBackColor = false;
            butQuit.Click += ClickQuit;
            // 
            // lblldrbrd
            // 
            lblldrbrd.AutoSize = true;
            lblldrbrd.BackColor = System.Drawing.Color.MediumSeaGreen;
            lblldrbrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            lblldrbrd.Location = new System.Drawing.Point(376, 17);
            lblldrbrd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblldrbrd.Name = "lblldrbrd";
            lblldrbrd.Padding = new System.Windows.Forms.Padding(12, 12, 12, 297);
            lblldrbrd.Size = new System.Drawing.Size(102, 322);
            lblldrbrd.TabIndex = 18;
            lblldrbrd.Text = "Leaderboard\r\n";
            lblldrbrd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ldrbrd
            // 
            ldrbrd.AutoSize = true;
            ldrbrd.BackColor = System.Drawing.Color.MediumSeaGreen;
            ldrbrd.ColumnCount = 3;
            ldrbrd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            ldrbrd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            ldrbrd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            ldrbrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ldrbrd.Location = new System.Drawing.Point(376, 61);
            ldrbrd.Margin = new System.Windows.Forms.Padding(0);
            ldrbrd.Name = "ldrbrd";
            ldrbrd.RowCount = 10;
            ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            ldrbrd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            ldrbrd.Size = new System.Drawing.Size(102, 248);
            ldrbrd.TabIndex = 19;
            // 
            // lblCS
            // 
            lblCS.AutoSize = true;
            lblCS.BackColor = System.Drawing.Color.MediumSeaGreen;
            lblCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            lblCS.Location = new System.Drawing.Point(383, 282);
            lblCS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCS.Name = "lblCS";
            lblCS.Size = new System.Drawing.Size(85, 13);
            lblCS.TabIndex = 20;
            lblCS.Text = "Current Score";
            // 
            // scoreCurrent
            // 
            scoreCurrent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            scoreCurrent.AutoSize = true;
            scoreCurrent.BackColor = System.Drawing.Color.MediumSeaGreen;
            scoreCurrent.Location = new System.Drawing.Point(33, 0);
            scoreCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            scoreCurrent.Name = "scoreCurrent";
            scoreCurrent.Size = new System.Drawing.Size(35, 62);
            scoreCurrent.TabIndex = 21;
            scoreCurrent.Text = "temp";
            scoreCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblActiveBet, 1, 1);
            tableLayoutPanel1.Controls.Add(betMin, 0, 2);
            tableLayoutPanel1.Controls.Add(betHalf, 1, 2);
            tableLayoutPanel1.Controls.Add(betAll, 2, 2);
            tableLayoutPanel1.Controls.Add(lblBet, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(78, 380);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(346, 115);
            tableLayoutPanel1.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(scoreCurrent, 0, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(376, 293);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(102, 62);
            tableLayoutPanel2.TabIndex = 24;
            // 
            // unitSymbol
            // 
            unitSymbol.AutoSize = true;
            unitSymbol.BackColor = System.Drawing.Color.Gold;
            unitSymbol.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            unitSymbol.Location = new System.Drawing.Point(18, 23);
            unitSymbol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            unitSymbol.Name = "unitSymbol";
            unitSymbol.Size = new System.Drawing.Size(19, 20);
            unitSymbol.TabIndex = 25;
            unitSymbol.Text = "$";
            // 
            // butSFX
            // 
            butSFX.BackColor = System.Drawing.Color.SkyBlue;
            butSFX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            butSFX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            butSFX.Location = new System.Drawing.Point(22, 380);
            butSFX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            butSFX.Name = "butSFX";
            butSFX.Size = new System.Drawing.Size(35, 35);
            butSFX.TabIndex = 26;
            butSFX.Text = "🔊";
            butSFX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            butSFX.UseVisualStyleBackColor = false;
            butSFX.Click += ClickSFX;
            // 
            // butMusic
            // 
            butMusic.BackColor = System.Drawing.Color.SkyBlue;
            butMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            butMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            butMusic.Location = new System.Drawing.Point(22, 460);
            butMusic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            butMusic.Name = "butMusic";
            butMusic.Size = new System.Drawing.Size(35, 35);
            butMusic.TabIndex = 27;
            butMusic.Text = "🎵";
            butMusic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            butMusic.UseVisualStyleBackColor = false;
            butMusic.Click += ClickMusic;
            // 
            // WMP
            // 
            WMP.Enabled = true;
            WMP.Location = new System.Drawing.Point(111, -17);
            WMP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            WMP.Name = "WMP";
            WMP.OcxState = (System.Windows.Forms.AxHost.State)resources.GetObject("WMP.OcxState");
            WMP.Size = new System.Drawing.Size(211, 32);
            WMP.TabIndex = 29;
            WMP.Visible = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SeaGreen;
            ClientSize = new System.Drawing.Size(500, 520);
            Controls.Add(WMP);
            Controls.Add(butMusic);
            Controls.Add(butSFX);
            Controls.Add(lblCS);
            Controls.Add(unitSymbol);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(ldrbrd);
            Controls.Add(lblldrbrd);
            Controls.Add(butQuit);
            Controls.Add(butStart);
            Controls.Add(lblRounds);
            Controls.Add(prvRnds);
            Controls.Add(fieldPlay);
            Controls.Add(butHold);
            Controls.Add(butHit);
            Controls.Add(funds);
            Controls.Add(tableLayoutPanel1);
            HelpButton = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Location = new System.Drawing.Point(0, 50);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(516, 559);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(516, 559);
            Name = "FormMain";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Black Jack";
            HelpButtonClicked += ClickHelp;
            Load += FormLoad;
            fieldPlay.ResumeLayout(false);
            fieldPlay.PerformLayout();
            fieldCount.ResumeLayout(false);
            fieldCount.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)WMP).EndInit();
            ResumeLayout(false);
            PerformLayout();
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

