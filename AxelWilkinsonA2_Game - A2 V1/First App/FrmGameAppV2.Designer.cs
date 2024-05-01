namespace First_App
{
    partial class FrmGameAppV2
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
            this.CbxGame = new System.Windows.Forms.ComboBox();
            this.BtnFindOverallWinner = new System.Windows.Forms.Button();
            this.LsvGameStatistics = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.LblPlayerScoreValue = new System.Windows.Forms.Label();
            this.LblComputerScoreValue = new System.Windows.Forms.Label();
            this.LblPlayerScore = new System.Windows.Forms.Label();
            this.LblComputerScore = new System.Windows.Forms.Label();
            this.LblPickGame = new System.Windows.Forms.Label();
            this.BtnPlayGame = new System.Windows.Forms.Button();
            this.TbxPlayersName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.GrbBlackjack = new System.Windows.Forms.GroupBox();
            this.LsvComputersHand = new System.Windows.Forms.ListView();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.LblPlayersHand = new System.Windows.Forms.Label();
            this.BtnHit = new System.Windows.Forms.Button();
            this.LblComputersHand = new System.Windows.Forms.Label();
            this.BtnStand = new System.Windows.Forms.Button();
            this.LsvPlayersHand = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.LblOverallGameResults = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.GrbBlackjack.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbxGame
            // 
            this.CbxGame.FormattingEnabled = true;
            this.CbxGame.Location = new System.Drawing.Point(118, 60);
            this.CbxGame.Name = "CbxGame";
            this.CbxGame.Size = new System.Drawing.Size(100, 23);
            this.CbxGame.TabIndex = 34;
            // 
            // BtnFindOverallWinner
            // 
            this.BtnFindOverallWinner.BackColor = System.Drawing.SystemColors.Info;
            this.BtnFindOverallWinner.Location = new System.Drawing.Point(12, 708);
            this.BtnFindOverallWinner.Name = "BtnFindOverallWinner";
            this.BtnFindOverallWinner.Size = new System.Drawing.Size(127, 62);
            this.BtnFindOverallWinner.TabIndex = 33;
            this.BtnFindOverallWinner.Text = "Fine Overall Winner";
            this.BtnFindOverallWinner.UseVisualStyleBackColor = false;
            // 
            // LsvGameStatistics
            // 
            this.LsvGameStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LsvGameStatistics.GridLines = true;
            this.LsvGameStatistics.Location = new System.Drawing.Point(12, 508);
            this.LsvGameStatistics.Name = "LsvGameStatistics";
            this.LsvGameStatistics.Size = new System.Drawing.Size(405, 194);
            this.LsvGameStatistics.TabIndex = 32;
            this.LsvGameStatistics.UseCompatibleStateImageBehavior = false;
            this.LsvGameStatistics.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Game Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Players Score";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Computers Score";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Winner";
            this.columnHeader4.Width = 80;
            // 
            // LblPlayerScoreValue
            // 
            this.LblPlayerScoreValue.AutoSize = true;
            this.LblPlayerScoreValue.Location = new System.Drawing.Point(277, 131);
            this.LblPlayerScoreValue.Name = "LblPlayerScoreValue";
            this.LblPlayerScoreValue.Size = new System.Drawing.Size(13, 15);
            this.LblPlayerScoreValue.TabIndex = 31;
            this.LblPlayerScoreValue.Text = "0";
            // 
            // LblComputerScoreValue
            // 
            this.LblComputerScoreValue.AutoSize = true;
            this.LblComputerScoreValue.Location = new System.Drawing.Point(277, 96);
            this.LblComputerScoreValue.Name = "LblComputerScoreValue";
            this.LblComputerScoreValue.Size = new System.Drawing.Size(13, 15);
            this.LblComputerScoreValue.TabIndex = 30;
            this.LblComputerScoreValue.Text = "0";
            // 
            // LblPlayerScore
            // 
            this.LblPlayerScore.AutoSize = true;
            this.LblPlayerScore.Location = new System.Drawing.Point(177, 131);
            this.LblPlayerScore.Name = "LblPlayerScore";
            this.LblPlayerScore.Size = new System.Drawing.Size(71, 15);
            this.LblPlayerScore.TabIndex = 29;
            this.LblPlayerScore.Text = "Player Score";
            // 
            // LblComputerScore
            // 
            this.LblComputerScore.AutoSize = true;
            this.LblComputerScore.Location = new System.Drawing.Point(155, 96);
            this.LblComputerScore.Name = "LblComputerScore";
            this.LblComputerScore.Size = new System.Drawing.Size(93, 15);
            this.LblComputerScore.TabIndex = 28;
            this.LblComputerScore.Text = "Computer Score";
            // 
            // LblPickGame
            // 
            this.LblPickGame.AutoSize = true;
            this.LblPickGame.Location = new System.Drawing.Point(33, 63);
            this.LblPickGame.Name = "LblPickGame";
            this.LblPickGame.Size = new System.Drawing.Size(63, 15);
            this.LblPickGame.TabIndex = 27;
            this.LblPickGame.Text = "Pick Game";
            // 
            // BtnPlayGame
            // 
            this.BtnPlayGame.BackColor = System.Drawing.SystemColors.Info;
            this.BtnPlayGame.Location = new System.Drawing.Point(27, 125);
            this.BtnPlayGame.Name = "BtnPlayGame";
            this.BtnPlayGame.Size = new System.Drawing.Size(91, 38);
            this.BtnPlayGame.TabIndex = 26;
            this.BtnPlayGame.Text = "Play";
            this.BtnPlayGame.UseVisualStyleBackColor = false;
            // 
            // TbxPlayersName
            // 
            this.TbxPlayersName.Location = new System.Drawing.Point(118, 26);
            this.TbxPlayersName.Name = "TbxPlayersName";
            this.TbxPlayersName.Size = new System.Drawing.Size(100, 23);
            this.TbxPlayersName.TabIndex = 25;
            this.TbxPlayersName.TextChanged += new System.EventHandler(this.TbxPlayersName_TextChanged_1);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(27, 29);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(69, 15);
            this.LblName.TabIndex = 24;
            this.LblName.Text = "Enter Name";
            // 
            // GrbBlackjack
            // 
            this.GrbBlackjack.Controls.Add(this.LsvComputersHand);
            this.GrbBlackjack.Controls.Add(this.LblPlayersHand);
            this.GrbBlackjack.Controls.Add(this.BtnHit);
            this.GrbBlackjack.Controls.Add(this.LblComputersHand);
            this.GrbBlackjack.Controls.Add(this.BtnStand);
            this.GrbBlackjack.Controls.Add(this.LsvPlayersHand);
            this.GrbBlackjack.Location = new System.Drawing.Point(27, 200);
            this.GrbBlackjack.Name = "GrbBlackjack";
            this.GrbBlackjack.Size = new System.Drawing.Size(834, 275);
            this.GrbBlackjack.TabIndex = 41;
            this.GrbBlackjack.TabStop = false;
            this.GrbBlackjack.Text = "Blackjack";
            // 
            // LsvComputersHand
            // 
            this.LsvComputersHand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.LsvComputersHand.GridLines = true;
            this.LsvComputersHand.Location = new System.Drawing.Point(511, 45);
            this.LsvComputersHand.Name = "LsvComputersHand";
            this.LsvComputersHand.Size = new System.Drawing.Size(319, 159);
            this.LsvComputersHand.TabIndex = 44;
            this.LsvComputersHand.UseCompatibleStateImageBehavior = false;
            this.LsvComputersHand.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Face";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Suit";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Value";
            this.columnHeader10.Width = 120;
            // 
            // LblPlayersHand
            // 
            this.LblPlayersHand.AutoSize = true;
            this.LblPlayersHand.Location = new System.Drawing.Point(132, 27);
            this.LblPlayersHand.Name = "LblPlayersHand";
            this.LblPlayersHand.Size = new System.Drawing.Size(79, 15);
            this.LblPlayersHand.TabIndex = 46;
            this.LblPlayersHand.Text = "Player\'s Hand";
            // 
            // BtnHit
            // 
            this.BtnHit.BackColor = System.Drawing.SystemColors.Info;
            this.BtnHit.Location = new System.Drawing.Point(4, 45);
            this.BtnHit.Name = "BtnHit";
            this.BtnHit.Size = new System.Drawing.Size(91, 38);
            this.BtnHit.TabIndex = 41;
            this.BtnHit.Text = "Hit";
            this.BtnHit.UseVisualStyleBackColor = false;
            // 
            // LblComputersHand
            // 
            this.LblComputersHand.AutoSize = true;
            this.LblComputersHand.Location = new System.Drawing.Point(511, 27);
            this.LblComputersHand.Name = "LblComputersHand";
            this.LblComputersHand.Size = new System.Drawing.Size(101, 15);
            this.LblComputersHand.TabIndex = 45;
            this.LblComputersHand.Text = "Computer\'s Hand";
            // 
            // BtnStand
            // 
            this.BtnStand.BackColor = System.Drawing.SystemColors.Info;
            this.BtnStand.Location = new System.Drawing.Point(4, 105);
            this.BtnStand.Name = "BtnStand";
            this.BtnStand.Size = new System.Drawing.Size(91, 38);
            this.BtnStand.TabIndex = 42;
            this.BtnStand.Text = "Stand";
            this.BtnStand.UseVisualStyleBackColor = false;
            // 
            // LsvPlayersHand
            // 
            this.LsvPlayersHand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.LsvPlayersHand.GridLines = true;
            this.LsvPlayersHand.Location = new System.Drawing.Point(132, 45);
            this.LsvPlayersHand.Name = "LsvPlayersHand";
            this.LsvPlayersHand.Size = new System.Drawing.Size(319, 159);
            this.LsvPlayersHand.TabIndex = 43;
            this.LsvPlayersHand.UseCompatibleStateImageBehavior = false;
            this.LsvPlayersHand.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Face";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Suit";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Value";
            this.columnHeader7.Width = 120;
            // 
            // LblOverallGameResults
            // 
            this.LblOverallGameResults.AutoSize = true;
            this.LblOverallGameResults.Location = new System.Drawing.Point(17, 490);
            this.LblOverallGameResults.Name = "LblOverallGameResults";
            this.LblOverallGameResults.Size = new System.Drawing.Size(118, 15);
            this.LblOverallGameResults.TabIndex = 47;
            this.LblOverallGameResults.Text = "Overall Game Results";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(931, 27);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(226, 51);
            this.LblTitle.TabIndex = 48;
            this.LblTitle.Text = "Axel\'s Game";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmGameAppV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1280, 790);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblOverallGameResults);
            this.Controls.Add(this.GrbBlackjack);
            this.Controls.Add(this.CbxGame);
            this.Controls.Add(this.BtnFindOverallWinner);
            this.Controls.Add(this.LsvGameStatistics);
            this.Controls.Add(this.LblPlayerScoreValue);
            this.Controls.Add(this.LblComputerScoreValue);
            this.Controls.Add(this.LblPlayerScore);
            this.Controls.Add(this.LblComputerScore);
            this.Controls.Add(this.LblPickGame);
            this.Controls.Add(this.BtnPlayGame);
            this.Controls.Add(this.TbxPlayersName);
            this.Controls.Add(this.LblName);
            this.Name = "FrmGameAppV2";
            this.Text = "FrmGameAppV2";
            this.Load += new System.EventHandler(this.FrmGameAppV2_Load);
            this.GrbBlackjack.ResumeLayout(false);
            this.GrbBlackjack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox CbxGame;
        private Button BtnFindOverallWinner;
        private ListView LsvGameStatistics;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label LblPlayerScoreValue;
        private Label LblComputerScoreValue;
        private Label LblPlayerScore;
        private Label LblComputerScore;
        private Label LblPickGame;
        private Button BtnPlayGame;
        private TextBox TbxPlayersName;
        private Label LblName;
        private GroupBox GrbBlackjack;
        private ListView LsvComputersHand;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Label LblPlayersHand;
        private Button BtnHit;
        private Label LblComputersHand;
        private Button BtnStand;
        private ListView LsvPlayersHand;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label LblOverallGameResults;
        private Label LblTitle;
    }
}