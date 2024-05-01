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
    public partial class FrmGameAppV2 : Form
    {
        public FrmGameAppV2()
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
        /// <summary>
        ///a. Declare Array of available Games,
        ///b. Clear exisiting CbxGame combo-box items
        ///c. Add each game in array to CbxGame Items
        ///</summary>
        private void FillCbxGame()
        {
            String[] availableGames = { "Dice", "Ten Sided Dice", "Twenty Sided Dice", "High Card Wins", "Blackjack" };
            CbxGame.Items.Clear();              //b
            foreach (String game in availableGames)
                CbxGame.Items.Add(game);                              //c
        }


        /// <summary>
        /// 
        /// </summary>
       
        private void FrmGameAppV2_Load(object sender, EventArgs e)
        {
            FillCbxGame();  // a
            ResetInterface(); // b
            this.BtnHit.Click += new System.EventHandler(this.BtnHit_Click);
            this.BtnStand.Click += new System.EventHandler(this.BtnStand_Click);

            this.BtnPlayGame.Click += new System.EventHandler(this.BtnPlayGame_Click);
            this.BtnFindOverallWinner.Click += new System.EventHandler(this.BtnFindOverallWinner_Click);
            this.TbxPlayersName.TextChanged += new System.EventHandler(this.TbxPlayersName_TextChanged);
            this.CbxGame.SelectedIndexChanged += new System.EventHandler(this.CbxGame_SelectedIndexChanged);

        }

        private void CbxGame_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (CbxGame.SelectedIndex != -1)
                BtnPlayGame.Enabled = true;
        }

        private void TbxPlayersName_TextChanged(object? sender, EventArgs e)
        {
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
            PlayGame(GameName);  //c
            Feedback = FindGameWinner();
            DisplayGameResult();

            if (GameName != "Blackjack")
            {
                Feedback = FindGameWinner(); //d
                DisplayGameResult(); //e
            }


        }//End of BtnPlayGame_Click event handler
        
        private void PlayGame(string? gameName)
        {
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

                    case "High Card Wins":
                        PlayTwentySidedDiceGame(); break;

                    case "Blackjack":
                        PlayBlackjackGame(); break;

                    default:
                        MessageBox.Show("Game Not Implemented", "Error"); break; //f
                }//End Switch


            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Implemented correctly" + ex.Message, "Exception Error");//a
            }
        }//End of Play Game


        /// <summary>
        /// 1. assigns the player dice the colour blue
        /// 2. assigns the computer dice the colour red
        /// 3. the player score is the number provided by the dice
        /// 4. the computer score is the number provided by the dice
        /// </summary>
        private void PlayTenSidedDiceGame()
        {
            try
            {
                TenSidedDice playerDice = new TenSidedDice("Blue"); //1
                TenSidedDice computerDice = new TenSidedDice("Red"); //2
                PlayersScore = playerDice.Num;                       //3
                ComputerScore = computerDice.Num;                     //4
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

            try
            {
                Dice playerDice = new Dice("Blue");          //a
                Dice computerDice = new Dice("Red");
                PlayersScore = playerDice.Num;              //b
                ComputerScore = computerDice.Num;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Implemented correctly " + ex.Message, "Exception Error");
            }
        }//End of PlayDiceGame

        private void DisplayOverallGameResult()
        {
            int playerWins = 0;
            int computerWins = 0;
            string result = "";

            int numOfGames = LsvGameStatistics.Items.Count;

            foreach (ListViewItem element in LsvGameStatistics.Items)
            {
                result = element.SubItems[3].Text;
                if (result.StartsWith("Player"))
                    playerWins += 1;
                else if (result.StartsWith("Computer"))
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
        /// <summary>
        /// a.an input box is displayed asking if they want to continue
        /// b.if the answer is y then the game continues
        /// c.but if they enter n then the game ends
        /// </summary>
        

        private char GetReply(string prompt)
        {
            string temp = InputBox.Show("Continue?", prompt);//a
            if (temp.ToUpper().StartsWith("Y"))
                return 'Y';                                 //b
            else
                return 'N';                                //c
        }//End of GetReply

        private void DisplayGameResult()
        {
            MessageBox.Show(Feedback, "Game Result");

            string[] row = { GameName, PlayersScore.ToString(), ComputerScore.ToString(), Winner }; //a
            var listViewItem = new ListViewItem(row);                                             //b
            LsvGameStatistics.Items.Add(listViewItem);                                            //c

        }

        private string FindGameWinner()
        {
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
            DisplayOverallGameResult();

        }




        Deck mainDeck = null;//new
        /// <summary>
        /// 
        /// </summary>
        private void PlayHighCardGame()
        {
            if (mainDeck == null) mainDeck = new Deck();//1

            PlayingCard playerCard = mainDeck.Deal();//2
            PlayersScore = playerCard.Value;//3


            PlayingCard computerCard = mainDeck.Deal();//4
            ComputerScore = computerCard.Value;//5
        }//End of  PlayHighCardGame

        //blackjack
        Hand ComputerHand = null; //2a
        Hand PlayerHand = null; //2b
        /// <summary>
        /// 1.if the main deck is null then it will create a new deck
        /// 2.if the players hand is null then it will create a new hand
        /// 3.deals a playerCard from the main deck
        /// 4.adds the new card to the players hand
        /// 5.displays the current card that the player is holding
        /// </summary>
        public void DealaPlayerCard() //2c
        {

            if (mainDeck == null)     //1
                mainDeck = new Deck();
            if (PlayerHand == null)
                PlayerHand = new Hand();    //2

            PlayingCard playerCard = mainDeck.Deal(); //3
            PlayerHand.AddCardToHand(playerCard); //4
            DisplayPlayerCard(playerCard); //5
        }
        public void DealaComputerCard() //2c
        {

            if (mainDeck == null)     //1
                mainDeck = new Deck();
            if (ComputerHand == null)
                ComputerHand = new Hand();    //2

            PlayingCard computerCard = mainDeck.Deal(); //3
            ComputerHand.AddCardToHand(computerCard); //4
            DisplayComputerCard(computerCard); //5
        }
        private void DisplayPlayerCard(PlayingCard playerCard) // moved
        {
            try
            {
                LsvPlayersHand.Items.Add(new ListViewItem(new[] { playerCard.Face.ToString(), playerCard.Suit.ToString() }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Display Card Error");
            }
        }
        private void DisplayComputerCard(PlayingCard computerCard) // moved
        {
            try
            {
                LsvComputersHand.Items.Add(new ListViewItem(new[] { computerCard.Face.ToString(), computerCard.Suit.ToString() }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Display Card Error");
            }
        }
        /// <summary>
        /// 1.deals 2 cards to player
        /// 2.sets the score to the value of the cards given
        /// 3.sets the value of the cards into the score label
        /// </summary>
        public void PlayBlackjackGame() //2d
        {
            DealaPlayerCard(); //1
            DealaPlayerCard();

            PlayersScore = PlayerHand.Value();  //2
            LblPlayerScoreValue.Text = PlayersScore.ToString(); //3
        }

        /// <summary>
        /// 1.deals the player a card
        /// 2.updates the the players hand value with the new score
        /// 3.updates the score that is in the score label
        /// </summary>

        public void BtnHit_Click(object sender, EventArgs e)
        {
            try
            {
                DealaPlayerCard();      //1
                PlayersScore = PlayerHand.Value();          //2
                LblPlayerScoreValue.Text = PlayersScore.ToString();    //3
                BtnStand_Click(BtnStand, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Display BtnHit Error");
            }
        }//end BtnHit_Click event handler
        public void DealaComputerHand()
        {
            DealaComputerCard();
            DealaComputerCard();

            ComputerScore = ComputerHand.Value();
            LblComputerScoreValue.Text = ComputerScore.ToString();
        }
        private void BtnStand_Click(object sender, EventArgs e)
        {
            try
            {
                DealaComputerHand();        //1
                Feedback = FindBlackjackGameWinner();
                DisplayGameResult();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Stand Error");
            }
        }//end BtnStand_Click
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string FindBlackjackGameWinner()
        {
            string feedback = "";
            if (PlayersScore >21)
                MessageBox.Show("You Lose");

            else if (ComputerScore >21)

                MessageBox.Show("You Win");

            return feedback;

        }//end FindBlackjackGameWinner


        private void LsvPlayersHand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmGameAppV2_Load_1(object sender, EventArgs e)
        {

        }

        private void TbxPlayersName_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
