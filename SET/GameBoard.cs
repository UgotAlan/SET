namespace SET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// This Form displays the GameBoard where
    /// the user will be able to interact with
    /// the game, along with other users.
    /// </summary>
    public partial class GameBoard : Form
    {
        private Processing game = new Processing();
        int numCardsSelected;
        List<Cards> currentSet = new List<Cards>();
        // create holder for the 12 cards for the game board. These need to be set when we call for a new card to be put on the board.
        private Cards[] cardsOnBoard;
        int[] cardsSelected = { 0, 0, 0 } ;

        // private int[] options; // dont think we need this since the settings are sent to game when form is created.

        /// <summary>
        /// Initializes a new instance of the GameBoard class.
        /// </summary>
        public GameBoard(int[] options)
        {
            InitializeComponent();
            game.startGame(options);

            cardsOnBoard = game.getCardsOnBoard();
            pictureBox1.BackgroundImage = Image.FromFile(cardsOnBoard[0].Image);
            pictureBox2.BackgroundImage = Image.FromFile(cardsOnBoard[1].Image);
            pictureBox3.BackgroundImage = Image.FromFile(cardsOnBoard[2].Image);
            pictureBox4.BackgroundImage = Image.FromFile(cardsOnBoard[3].Image);
            pictureBox5.BackgroundImage = Image.FromFile(cardsOnBoard[4].Image);
            pictureBox6.BackgroundImage = Image.FromFile(cardsOnBoard[5].Image);
            pictureBox7.BackgroundImage = Image.FromFile(cardsOnBoard[6].Image);
            pictureBox8.BackgroundImage = Image.FromFile(cardsOnBoard[7].Image);
            pictureBox9.BackgroundImage = Image.FromFile(cardsOnBoard[8].Image);
            pictureBox10.BackgroundImage = Image.FromFile(cardsOnBoard[9].Image);
            pictureBox11.BackgroundImage = Image.FromFile(cardsOnBoard[10].Image);
            pictureBox12.BackgroundImage = Image.FromFile(cardsOnBoard[11].Image);

            // set score
            updateScoreBoard();
        }

        /// <summary>
        /// Event handler for user clicking the button labeled set.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void SetButtonClick(object sender, EventArgs e)
        {
            // Set Logic
            if (numCardsSelected == 3)
            {
                if(currentSet.Count() == 3 && game.ConfirmSet(currentSet) == true)
                {
                    game.setUserScore(1, 1);
                    // update scoreboard
                    updateScoreBoard();
                    // get rid of selected cards from board and get new cards
                    MessageBox.Show("You have a valid set, YAY!");
                }
                else
                {               
                    game.setUserScore(1, -1);
                    updateScoreBoard();
                    MessageBox.Show("Your SET is NOT valid!");
                }
            }
            else
            {
                MessageBox.Show("You need to have 3 cards selected to declare a SET");
            }
        }

        private void updateScoreBoard()
        {
            player1Score.Text = game.getUserScore(1).ToString();
            // player2Score.Text = game.getUserScore(2).ToString();
            // player3Score.Text = game.getUserScore(3).ToString();
            // player4Score.Text = game.getUserScore(4).ToString();
            // player5Score.Text = game.getUserScore(5).ToString();
        }

        /// <summary>
        /// Event handler for user's cursor entering the button labeled set.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void SetButtonMouseOver(object sender, EventArgs e)
        {
            setButton.BackColor = Color.Gold;
        }

        /// <summary>
        /// Event handler for user's cursor leaving the button labeled set.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void SetButtonMouseLeave(object sender, EventArgs e)
        {
            setButton.BackColor = Color.Goldenrod;
        }

        /// <summary>
        /// Event handler for user click the button labeled options.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void OptionsButtonClick(object sender, EventArgs e)
        {
            // Bring up options dialog
        //    GeneralOptions options = new GeneralOptions();
        //    options.ShowDialog();
        }

        /// <summary>
        /// Event handler for user click on the button labeled exit.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void ExitButtonClick(object sender, EventArgs e)
        {
            // Bring up exit dialog
            if ("Yes" == MessageBox.Show("Are you sure you want to quit this game?", "Are you sure?", MessageBoxButtons.YesNo).ToString())
            {
                this.Close();
            }
        }

        /// <summary>
        /// Event handler for user's cursor entering the button labeled options.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void OptionsButtonMouseOver(object sender, EventArgs e)
        {
            optionsButton.ForeColor = Color.LightGray;
        }

        /// <summary>
        /// Event handler for user's cursor leaving the button labeled options.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void OptionsButtonMouseLeave(object sender, EventArgs e)
        {
            optionsButton.ForeColor = Color.White;
        }

        /// <summary>
        /// Event handler for user's cursor entering the button labeled exit.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void ExitButtonMouseEnter(object sender, EventArgs e)
        {
            exitButton.ForeColor = Color.LightGray;
        }

        /// <summary>
        /// Event handler for user's cursor leaving the button labeled exit.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void ExitButtonMouseLeave(object sender, EventArgs e)
        {
            exitButton.ForeColor = Color.White;
        }

        /// <summary>
        /// Event handler for highlighting a card when selected.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Gold)
            {
                pictureBox1.BackColor = Color.FromArgb(0x575757);
                removeCurrentCard(1);               
            }
            else if (numCardsSelected < 3)
            {
                pictureBox1.BackColor = Color.Gold;
                addCurrentCard(1); 
            }
        }

        private void addCurrentCard(int v)
        {
            currentSet.Add(cardsOnBoard[v - 1]);
                for(int i = 0; i < 3; i++)
                {
                    if (cardsSelected[i] == 0)
                    {
                        cardsSelected[i] = v;
                        break;
                    }
                }
                ++numCardsSelected;
        }

        private void removeCurrentCard(int v)
        {
             for (int i = 0; i < 3; i++)
                {
                    if (cardsSelected[i] == v)
                    {
                        currentSet.RemoveAt(i);
                        for (int j = i; j < 2; j++)
                    {
                        cardsSelected[j] = cardsSelected[j + 1];
                    }
                        cardsSelected[2] = 0;
                        break;
                    }
                }
                --numCardsSelected;
        }

        /// <summary>
        /// Event handler for highlighting a card when selected.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.Gold)
            {
                pictureBox2.BackColor = Color.FromArgb(0x575757);
                removeCurrentCard(2);
            }
            else if (numCardsSelected < 3)
            {
                pictureBox2.BackColor = Color.Gold;
                addCurrentCard(2);
            }
        }

        /// <summary>
        /// Event handler for highlighting a card when selected.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.BackColor == Color.Gold)
            {
                pictureBox3.BackColor = Color.FromArgb(0x575757);
                removeCurrentCard(3);
            }
            else if (numCardsSelected < 3)
            {
                pictureBox3.BackColor = Color.Gold;
                addCurrentCard(3);
            }
        }

        /// <summary>
        /// Event handler for highlighting a card when selected.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.BackColor == Color.Gold)
            {
                pictureBox4.BackColor = Color.FromArgb(0x575757);
                removeCurrentCard(4);
            }
            else if (numCardsSelected < 3)
            {
                pictureBox4.BackColor = Color.Gold;
                addCurrentCard(4);
            }
        }

        /// <summary>
        /// Event handler for highlighting a card when selected.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void PictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.BackColor == Color.Gold)
            {
                pictureBox5.BackColor = Color.FromArgb(0x575757);
                removeCurrentCard(5);
            }
            else if (numCardsSelected < 3)
            {
                pictureBox5.BackColor = Color.Gold;
                addCurrentCard(5);
            }
        }

        /// <summary>
        /// Event handler for highlighting a card when selected.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void PictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.BackColor == Color.Gold)
            {
                pictureBox6.BackColor = Color.FromArgb(0x575757);
                removeCurrentCard(6);
            }
            else if (numCardsSelected < 3)
            {
                pictureBox6.BackColor = Color.Gold;
                addCurrentCard(6);
            }
        }

        /// <summary>
        /// Event handler for highlighting a card when selected.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void PictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.BackColor == Color.Gold)
            {
                pictureBox7.BackColor = Color.FromArgb(0x575757);
                removeCurrentCard(7);
            }
            else if (numCardsSelected < 3)
            {
                pictureBox7.BackColor = Color.Gold;
                addCurrentCard(7);
            }
        }

        /// <summary>
        /// Event handler for highlighting a card when selected.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void PictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox8.BackColor == Color.Gold)
            {
                pictureBox8.BackColor = Color.FromArgb(0x575757);
                removeCurrentCard(8);
            }
            else if (numCardsSelected < 3)
            {
                pictureBox8.BackColor = Color.Gold;
                addCurrentCard(8);
            }
        }

        /// <summary>
        /// Event handler for highlighting a card when selected.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void PictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.BackColor == Color.Gold)
            {
                pictureBox9.BackColor = Color.FromArgb(0x575757);
                removeCurrentCard(9);
            }
            else if (numCardsSelected < 3)
            {
                pictureBox9.BackColor = Color.Gold;
                addCurrentCard(9);
            }
        }

        /// <summary>
        /// Event handler for highlighting a card when selected.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void PictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox10.BackColor == Color.Gold)
            {
                pictureBox10.BackColor = Color.FromArgb(0x575757);
                removeCurrentCard(10);
            }
            else if (numCardsSelected < 3)
            {
                pictureBox10.BackColor = Color.Gold;
                addCurrentCard(10);
            }
        }

        /// <summary>
        /// Event handler for highlighting a card when selected.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void PictureBox11_Click(object sender, EventArgs e)
        {
            if (pictureBox11.BackColor == Color.Gold)
            {
                pictureBox11.BackColor = Color.FromArgb(0x575757);
                removeCurrentCard(11);
            }
            else if (numCardsSelected < 3)
            {
                pictureBox11.BackColor = Color.Gold;
                addCurrentCard(11);
            }
        }

        /// <summary>
        /// Event handler for highlighting a card when selected.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void PictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox12.BackColor == Color.Gold)
            {
                pictureBox12.BackColor = Color.FromArgb(0x575757);
                removeCurrentCard(12);
            }
            else if (numCardsSelected < 3)
            {
                pictureBox12.BackColor = Color.Gold;
                addCurrentCard(12);
            }
        }
    }
}