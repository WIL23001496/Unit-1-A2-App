namespace First_App
{
    partial class FrmGameApp
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
            this.BtnPlayGame = new System.Windows.Forms.Button();
            this.TbxPlayersName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblPickGame = new System.Windows.Forms.Label();
            this.LblComputerScore = new System.Windows.Forms.Label();
            this.LblPlayerScore = new System.Windows.Forms.Label();
            this.LblComputerScoreValue = new System.Windows.Forms.Label();
            this.LblPlayerScoreValue = new System.Windows.Forms.Label();
            this.LsvGameStatistics = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.BtnFindOverallWinner = new System.Windows.Forms.Button();
            this.CbxGame = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnPlayGame
            // 
            this.BtnPlayGame.Location = new System.Drawing.Point(59, 141);
            this.BtnPlayGame.Name = "BtnPlayGame";
            this.BtnPlayGame.Size = new System.Drawing.Size(91, 38);
            this.BtnPlayGame.TabIndex = 14;
            this.BtnPlayGame.Text = "Play";
            this.BtnPlayGame.UseVisualStyleBackColor = true;
            // 
            // TbxPlayersName
            // 
            this.TbxPlayersName.Location = new System.Drawing.Point(150, 42);
            this.TbxPlayersName.Name = "TbxPlayersName";
            this.TbxPlayersName.Size = new System.Drawing.Size(100, 23);
            this.TbxPlayersName.TabIndex = 13;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(59, 45);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(69, 15);
            this.LblName.TabIndex = 12;
            this.LblName.Text = "Enter Name";
            // 
            // LblPickGame
            // 
            this.LblPickGame.AutoSize = true;
            this.LblPickGame.Location = new System.Drawing.Point(65, 79);
            this.LblPickGame.Name = "LblPickGame";
            this.LblPickGame.Size = new System.Drawing.Size(63, 15);
            this.LblPickGame.TabIndex = 15;
            this.LblPickGame.Text = "Pick Game";
            // 
            // LblComputerScore
            // 
            this.LblComputerScore.AutoSize = true;
            this.LblComputerScore.Location = new System.Drawing.Point(187, 141);
            this.LblComputerScore.Name = "LblComputerScore";
            this.LblComputerScore.Size = new System.Drawing.Size(93, 15);
            this.LblComputerScore.TabIndex = 17;
            this.LblComputerScore.Text = "Computer Score";
            // 
            // LblPlayerScore
            // 
            this.LblPlayerScore.AutoSize = true;
            this.LblPlayerScore.Location = new System.Drawing.Point(209, 176);
            this.LblPlayerScore.Name = "LblPlayerScore";
            this.LblPlayerScore.Size = new System.Drawing.Size(71, 15);
            this.LblPlayerScore.TabIndex = 18;
            this.LblPlayerScore.Text = "Player Score";
            // 
            // LblComputerScoreValue
            // 
            this.LblComputerScoreValue.AutoSize = true;
            this.LblComputerScoreValue.Location = new System.Drawing.Point(309, 141);
            this.LblComputerScoreValue.Name = "LblComputerScoreValue";
            this.LblComputerScoreValue.Size = new System.Drawing.Size(13, 15);
            this.LblComputerScoreValue.TabIndex = 19;
            this.LblComputerScoreValue.Text = "0";
            // 
            // LblPlayerScoreValue
            // 
            this.LblPlayerScoreValue.AutoSize = true;
            this.LblPlayerScoreValue.Location = new System.Drawing.Point(309, 176);
            this.LblPlayerScoreValue.Name = "LblPlayerScoreValue";
            this.LblPlayerScoreValue.Size = new System.Drawing.Size(13, 15);
            this.LblPlayerScoreValue.TabIndex = 20;
            this.LblPlayerScoreValue.Text = "0";
            // 
            // LsvGameStatistics
            // 
            this.LsvGameStatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LsvGameStatistics.GridLines = true;
            this.LsvGameStatistics.Location = new System.Drawing.Point(187, 208);
            this.LsvGameStatistics.Name = "LsvGameStatistics";
            this.LsvGameStatistics.Size = new System.Drawing.Size(465, 194);
            this.LsvGameStatistics.TabIndex = 21;
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
            // BtnFindOverallWinner
            // 
            this.BtnFindOverallWinner.Location = new System.Drawing.Point(59, 364);
            this.BtnFindOverallWinner.Name = "BtnFindOverallWinner";
            this.BtnFindOverallWinner.Size = new System.Drawing.Size(91, 38);
            this.BtnFindOverallWinner.TabIndex = 22;
            this.BtnFindOverallWinner.Text = "Fine Overall Winner";
            this.BtnFindOverallWinner.UseVisualStyleBackColor = true;
            // 
            // CbxGame
            // 
            this.CbxGame.FormattingEnabled = true;
            this.CbxGame.Location = new System.Drawing.Point(150, 76);
            this.CbxGame.Name = "CbxGame";
            this.CbxGame.Size = new System.Drawing.Size(100, 23);
            this.CbxGame.TabIndex = 23;
            // 
            // FrmGameApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FrmGameApp";
            this.Text = "Play Your Dice Game";
            this.Load += new System.EventHandler(this.FrmGameApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnPlayGame;
        private TextBox TbxPlayersName;
        private Label LblName;
        private Label LblPickGame;
        private Label LblComputerScore;
        private Label LblPlayerScore;
        private Label LblComputerScoreValue;
        private Label LblPlayerScoreValue;
        private ListView LsvGameStatistics;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button BtnFindOverallWinner;
        private ComboBox CbxGame;
    }
}