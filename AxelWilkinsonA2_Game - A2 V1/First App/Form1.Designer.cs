namespace First_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblEnterTemperature = new System.Windows.Forms.Label();
            this.LblEnterMark = new System.Windows.Forms.Label();
            this.LblEnterGuess = new System.Windows.Forms.Label();
            this.TbxFirstName = new System.Windows.Forms.TextBox();
            this.TbxLastName = new System.Windows.Forms.TextBox();
            this.TbxTemp = new System.Windows.Forms.TextBox();
            this.TbxMark = new System.Windows.Forms.TextBox();
            this.CbxGuess = new System.Windows.Forms.ComboBox();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnGradeBasedOnMark = new System.Windows.Forms.Button();
            this.BtnPlayGuessingGame = new System.Windows.Forms.Button();
            this.BtnGuessingGame_P = new System.Windows.Forms.Button();
            this.BtnPlayBadDice = new System.Windows.Forms.Button();
            this.BtnPlayBetterDice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(38, 50);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(94, 15);
            this.LblFirstName.TabIndex = 0;
            this.LblFirstName.Text = "Enter First Name";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(38, 79);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(93, 15);
            this.LblLastName.TabIndex = 1;
            this.LblLastName.Text = "Enter Last Name";
            // 
            // LblEnterTemperature
            // 
            this.LblEnterTemperature.AutoSize = true;
            this.LblEnterTemperature.Location = new System.Drawing.Point(38, 110);
            this.LblEnterTemperature.Name = "LblEnterTemperature";
            this.LblEnterTemperature.Size = new System.Drawing.Size(103, 15);
            this.LblEnterTemperature.TabIndex = 2;
            this.LblEnterTemperature.Text = "Enter Temperature";
            // 
            // LblEnterMark
            // 
            this.LblEnterMark.AutoSize = true;
            this.LblEnterMark.Location = new System.Drawing.Point(38, 143);
            this.LblEnterMark.Name = "LblEnterMark";
            this.LblEnterMark.Size = new System.Drawing.Size(64, 15);
            this.LblEnterMark.TabIndex = 3;
            this.LblEnterMark.Text = "Enter Mark";
            // 
            // LblEnterGuess
            // 
            this.LblEnterGuess.AutoSize = true;
            this.LblEnterGuess.Location = new System.Drawing.Point(38, 174);
            this.LblEnterGuess.Name = "LblEnterGuess";
            this.LblEnterGuess.Size = new System.Drawing.Size(68, 15);
            this.LblEnterGuess.TabIndex = 4;
            this.LblEnterGuess.Text = "Enter Guess";
            // 
            // TbxFirstName
            // 
            this.TbxFirstName.Location = new System.Drawing.Point(154, 47);
            this.TbxFirstName.Name = "TbxFirstName";
            this.TbxFirstName.Size = new System.Drawing.Size(100, 23);
            this.TbxFirstName.TabIndex = 5;
            // 
            // TbxLastName
            // 
            this.TbxLastName.Location = new System.Drawing.Point(154, 76);
            this.TbxLastName.Name = "TbxLastName";
            this.TbxLastName.Size = new System.Drawing.Size(100, 23);
            this.TbxLastName.TabIndex = 6;
            // 
            // TbxTemp
            // 
            this.TbxTemp.Location = new System.Drawing.Point(154, 107);
            this.TbxTemp.Name = "TbxTemp";
            this.TbxTemp.Size = new System.Drawing.Size(100, 23);
            this.TbxTemp.TabIndex = 7;
            // 
            // TbxMark
            // 
            this.TbxMark.Location = new System.Drawing.Point(154, 140);
            this.TbxMark.Name = "TbxMark";
            this.TbxMark.Size = new System.Drawing.Size(100, 23);
            this.TbxMark.TabIndex = 9;
            // 
            // CbxGuess
            // 
            this.CbxGuess.FormattingEnabled = true;
            this.CbxGuess.Location = new System.Drawing.Point(154, 174);
            this.CbxGuess.Name = "CbxGuess";
            this.CbxGuess.Size = new System.Drawing.Size(100, 23);
            this.CbxGuess.TabIndex = 10;
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(347, 38);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(91, 38);
            this.BtnPlay.TabIndex = 11;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnGradeBasedOnMark
            // 
            this.BtnGradeBasedOnMark.Location = new System.Drawing.Point(347, 92);
            this.BtnGradeBasedOnMark.Name = "BtnGradeBasedOnMark";
            this.BtnGradeBasedOnMark.Size = new System.Drawing.Size(91, 38);
            this.BtnGradeBasedOnMark.TabIndex = 12;
            this.BtnGradeBasedOnMark.Text = "Grade Based On Mark";
            this.BtnGradeBasedOnMark.UseVisualStyleBackColor = true;
            this.BtnGradeBasedOnMark.Click += new System.EventHandler(this.BtnGradeBasedOnMark_Click);
            // 
            // BtnPlayGuessingGame
            // 
            this.BtnPlayGuessingGame.Location = new System.Drawing.Point(347, 143);
            this.BtnPlayGuessingGame.Name = "BtnPlayGuessingGame";
            this.BtnPlayGuessingGame.Size = new System.Drawing.Size(91, 38);
            this.BtnPlayGuessingGame.TabIndex = 13;
            this.BtnPlayGuessingGame.Text = "Play Guessing Game V1";
            this.BtnPlayGuessingGame.UseVisualStyleBackColor = true;
            this.BtnPlayGuessingGame.Click += new System.EventHandler(this.BtnPlayGuessingGame_Click);
            // 
            // BtnGuessingGame_P
            // 
            this.BtnGuessingGame_P.Location = new System.Drawing.Point(154, 220);
            this.BtnGuessingGame_P.Name = "BtnGuessingGame_P";
            this.BtnGuessingGame_P.Size = new System.Drawing.Size(91, 38);
            this.BtnGuessingGame_P.TabIndex = 14;
            this.BtnGuessingGame_P.Text = "Play Guessing Game P";
            this.BtnGuessingGame_P.UseVisualStyleBackColor = true;
            this.BtnGuessingGame_P.Click += new System.EventHandler(this.BtnGuessingGame_P_Click);
            // 
            // BtnPlayBadDice
            // 
            this.BtnPlayBadDice.Location = new System.Drawing.Point(154, 275);
            this.BtnPlayBadDice.Name = "BtnPlayBadDice";
            this.BtnPlayBadDice.Size = new System.Drawing.Size(91, 38);
            this.BtnPlayBadDice.TabIndex = 15;
            this.BtnPlayBadDice.Text = "Play Bad Dice Game";
            this.BtnPlayBadDice.UseVisualStyleBackColor = true;
            // 
            // BtnPlayBetterDice
            // 
            this.BtnPlayBetterDice.Location = new System.Drawing.Point(154, 329);
            this.BtnPlayBetterDice.Name = "BtnPlayBetterDice";
            this.BtnPlayBetterDice.Size = new System.Drawing.Size(91, 38);
            this.BtnPlayBetterDice.TabIndex = 16;
            this.BtnPlayBetterDice.Text = "Play 6 Sided Dice Game";
            this.BtnPlayBetterDice.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPlayBetterDice);
            this.Controls.Add(this.BtnPlayBadDice);
            this.Controls.Add(this.BtnGuessingGame_P);
            this.Controls.Add(this.BtnPlayGuessingGame);
            this.Controls.Add(this.BtnGradeBasedOnMark);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.CbxGuess);
            this.Controls.Add(this.TbxMark);
            this.Controls.Add(this.TbxTemp);
            this.Controls.Add(this.TbxLastName);
            this.Controls.Add(this.TbxFirstName);
            this.Controls.Add(this.LblEnterGuess);
            this.Controls.Add(this.LblEnterMark);
            this.Controls.Add(this.LblEnterTemperature);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblFirstName;
        private Label LblLastName;
        private Label LblEnterTemperature;
        private Label LblEnterMark;
        private Label LblEnterGuess;
        private TextBox TbxFirstName;
        private TextBox TbxLastName;
        private TextBox TbxTemp;
        private TextBox TbxMark;
        private ComboBox CbxGuess;
        private Button BtnPlay;
        private Button BtnGradeBasedOnMark;
        private Button BtnPlayGuessingGame;
        private Button BtnGuessingGame_P;
        private Button BtnPlayBadDice;
        private Button BtnPlayBetterDice;
    }
}