using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_App
{
    public partial class FrmGameApp : Form
    {
        public FrmGameApp()
        {
            InitializeComponent();
        }

        private void ResetInterface()
        {
            TbxPlayersName.Text = "";//a
            CbxGame.SelectedIndex = -1;//b
            CbxGame.Enabled = false;//c
            BtnPlayGame.Enabled = false;//d
            LsvGameStatistics.Items.Clear();//e

        }

        private void FillCbxGame()
        {
            string[] availableGames = { "Dice", "Ten Sided Dice", "Twenty Sided Dice" };//a
            CbxGame.Items.Clear();                                               //b
            foreach (string game in availableGames)        
                   CbxGame.Items.Add(game);                                 //c
        }




        private void FrmGameApp_Load(object sender, EventArgs e)
        {
            FillCbxGame();  // a
            ResetInterface(); // b

            this.BtnPlayGame.Click += new System.EventHandler(this.BtnPlayGame_Click);
            this.BtnFindOverallWinner.Click += new System.EventHandler(this.BtnFindOverallWinner_Click);
            this.TbxPlayersName.TextChanged += new System.EventHandler(this.TbxPlayersName_TextChanged);
            this.CbxGame.SelectedIndexChanged += new System.EventHandler(this.CbxGame_SelectedIndexChanged);

        }

        private void CbxGame_SelectedIndexChanged(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (CbxGame.SelectedIndex != -1)
                BtnPlayGame.Enabled = true;
        }

        private void TbxPlayersName_TextChanged(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (TbxPlayersName.Text.Length > 1)
                CbxGame.Enabled = true; 
        }//End of TbxPlayersName_TextChanged


        //Global Variables
        public string GameName = "";
        public string PlayersName = "";
        public int PlayersScore = 0;
        public int ComputerScore = 0;
        public string Feedback = "";
        public string Winner = "";
        private void BtnPlayGame_Click(object? sender, EventArgs e)
        {
        PlayersName = TbxPlayersName.Text.TrimEnd(); //a
        GameName = CbxGame.SelectedItem.ToString();//b

            char reply = 'Y';                     //c
            do
            {
                PlayGame(GameName);          //e
                Feedback = FindGameWinner();    //f
                DisplayGameResult();            //g
                reply = GetReply("Do you want to play another game?");//h

            } while (reply == 'Y');              //d
          
            DisplayOverallGameResult();          //h
            
    }//End of BtnPlayGame_Click event handler

        private void PlayGame(string? gameName)
        {
            //throw new NotImplementedException();
            try
            {
                switch (gameName)           //b
                {
                    case "Dice":
                        PlayDiceGame(); break; //c

                    case "Ten Sided Dice"://4b
                        PlayTenSidedDiceGame(); break;//d
                    
                    case "Twenty Sided Dice":
                        PlayTwentySidedDiceGame(); break;//e
                   
                    default:
                        MessageBox.Show("Game Not Implemented", "Error"); break; //f
                }//End Switch
           

            }catch (Exception ex)
            {
                MessageBox.Show("Not Implemented correctly" + ex.Message, "Exception Error");//a
            }
        }//End of Play Game

        private void PlayTenSidedDiceGame()
        {
            try
            {
                TenSidedDice playerDice = new TenSidedDice("Blue"); //1
                TenSidedDice computerDice = new TenSidedDice("Red"); //2
                PlayersScore = playerDice.Num;                       //3
                ComputerScore= computerDice.Num;                     //4
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Implemented correctly" + ex.Message, "Exception Error"); //5

            }
        }//End of PlayTenSidedDiceGame

        private void PlayTwentySidedDiceGame()
        {
            try
            {
                TwentySidedDice playerDice = new TwentySidedDice("Blue"); 
                TwentySidedDice computerDice = new TwentySidedDice("Red"); 
                PlayersScore = playerDice.Num;
                ComputerScore = computerDice.Num;                     
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Implemented correctly" + ex.Message, "Exception Error"); 

            }
        }//End of PlayTwentySidedDiceGame

        private void PlayDiceGame()
        {
            // throw new NotImplementedException();



            try
            {
                Dice playerDice = new Dice("Blue");          //a
                Dice computerDice = new Dice("Red");        
                PlayersScore = playerDice.Num;              //b
                ComputerScore = computerDice.Num;





            } catch (Exception ex)
            {
                MessageBox.Show("Not Implemented correctly " + ex.Message, "Exception Error");
            }
        }//End of PlayDiceGame

        private void DisplayOverallGameResult()
        {
            // throw new NotImplementedException();

            int playerWins = 0;
            int computerWins = 0;
            string result = "";

            int numOfGames = LsvGameStatistics.Items.Count;

            foreach (ListViewItem element in LsvGameStatistics.Items)
            {
                result = element.SubItems[3].Text;    
                if (result.StartsWith("Player"))
                    playerWins += 1;
                else if (result.StartsWith ("Computer"))
                        computerWins += 1;
            }//End for

            if (playerWins > computerWins)
                result = $"{PlayersName} wins as they won {playerWins} games which is higher than {computerWins}";
            else if (playerWins < computerWins)
                result = $"Computer wins as they won {computerWins} games which is higher than {playerWins}";
            if (playerWins == computerWins)
                result = $"Draw as both won {computerWins} games.";

            MessageBox.Show(result, "Overall Result");
        }

        private char GetReply(string prompt)
        {
            //throw new NotImplementedException();

            string temp = InputBox.Show("Continue?", prompt);//a
            if (temp.ToUpper().StartsWith("Y"))
                return 'Y';                                 //b
            else
                return 'N';                                //c
        }//End of GetReply

        private void DisplayGameResult()
        {
            //throw new NotImplementedException();

            MessageBox.Show(Feedback, "Game Result");

            string[] row = {GameName, PlayersScore.ToString(), ComputerScore.ToString(), Winner}; //a
            var listViewItem = new ListViewItem(row);                                             //b
            LsvGameStatistics.Items.Add(listViewItem);                                            //c

        }

        private string FindGameWinner()
        {
            // throw new NotImplementedException();
            string Feedback = "";
            if (PlayersScore == ComputerScore)
            {
                Feedback = $"Draw as {PlayersScore} was equal to {ComputerScore}"; //5c
                Winner = "Draw";
            }
            else if (PlayersScore > ComputerScore)
            {
                Feedback = $"{PlayersName} wins as {PlayersScore} is higher than {ComputerScore}";
                Winner = "Player";
            }

            else if (PlayersScore < ComputerScore)
            {
                Feedback = $"{PlayersName} loses as {PlayersScore} is lower than {ComputerScore}";
                Winner = "Computer";
            }
            return Feedback;
        }

      

        private void BtnFindOverallWinner_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
