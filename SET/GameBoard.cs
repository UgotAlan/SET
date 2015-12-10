namespace SET
{
    using Properties;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
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

        int cardsSelected;
        List<Cards> currentSet = new List<Cards>();
        // create holder for the 12 cards for the game board. These need to be set when we call for a new card to be put on the board.
        List<Cards> cardsOnBoard;

        /// <summary>
        /// Initializes a new instance of the GameBoard class.
        /// </summary>
        public GameBoard(int[] options)
        {
            InitializeComponent();
            game.startGame(options);
            cardsOnBoard = new List<Cards>();
            updateCardsOnBoard();
            cardsOnBoard = game.getCardsOnBoard();
        }

        /// <summary>
        /// Event handler for user clicking the button labeled set.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void SetButtonClick(object sender, EventArgs e)
        {
            Sounds sound = new Sounds();
            string directoryName = Path.GetDirectoryName(Directory.GetCurrentDirectory());
            directoryName = Path.GetDirectoryName(directoryName);
            directoryName = Path.GetDirectoryName(directoryName);
            directoryName = directoryName + "\\set_sounds\\sound_options.txt";
            string text = System.IO.File.ReadAllText(directoryName);

            // Set Logic
            if (cardsSelected == 3)
            {
                int set = game.ConfirmSet(currentSet);
                if (currentSet.Count() == 3 && set > 0)
                {
                    if (text == "true")
                    {
                        sound.PlayRight(true);
                    }
                    if (set == 2)
                    {
                        if ("Yes" == MessageBox.Show("Do you want to see the sets you made?", "Congratulations?", MessageBoxButtons.YesNo).ToString())
                        {
                            var card = game.getUserSets();
                            string toDisplay = "";
                            string line = "";
                            for(int i = 0; i < card.Count; i ++)
                            {
                                line = "Set" + i + ": ";
                                for(int j = 0; j < card[i].Count; j++)
                                {
                                    line += card[i][j].Number + "_" + card[i][j].Color + "_" + card[i][j].Shade + "_" + card[i][j].Shape + ", ";
                                }
                                toDisplay = string.Join(Environment.NewLine, line);
                            }
                           
                            MessageBox.Show(toDisplay);
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("You have a valid set, YAY!");
                        updateCardsOnBoard();
                        clearSelectedCards();
                    }
                   
                }
                else
                {
                    if (text == "true")
                    {
                        sound.PlayWrong(true);
                    }

                    MessageBox.Show("Your SET is NOT valid!");
                }
                // Fix this if you use multiple players
                player1Score.Text = game.getUserScore().ToString();
            }
            else
            {
                MessageBox.Show("You need to have 3 cards selected to declare a SET");
            }
        }

        private void clearSelectedCards()
        {
            cardsSelected = 0;
            currentSet.Clear();
            pictureBox1.BackColor = Color.FromArgb(0x575757);
            pictureBox2.BackColor = Color.FromArgb(0x575757);
            pictureBox3.BackColor = Color.FromArgb(0x575757);
            pictureBox4.BackColor = Color.FromArgb(0x575757);
            pictureBox5.BackColor = Color.FromArgb(0x575757);
            pictureBox6.BackColor = Color.FromArgb(0x575757);
            pictureBox7.BackColor = Color.FromArgb(0x575757);
            pictureBox8.BackColor = Color.FromArgb(0x575757);
            pictureBox9.BackColor = Color.FromArgb(0x575757);
            pictureBox10.BackColor = Color.FromArgb(0x575757);
            pictureBox11.BackColor = Color.FromArgb(0x575757);
            pictureBox12.BackColor = Color.FromArgb(0x575757);
        }

        private void updateCardsOnBoard()
        {
            cardsOnBoard = game.getCardsOnBoard();
            int counter = 0;
            foreach (Cards card in cardsOnBoard)
            {
                ++counter;
                Image image;
                image = getImageFromPath(card.Image);

                switch(counter)
                {
                    case 1:
                        pictureBox1.BackgroundImage = image;
                        break;
                    case 2:
                        pictureBox2.BackgroundImage = image;
                        break;
                    case 3:
                        pictureBox3.BackgroundImage = image;
                        break;
                    case 4:
                        pictureBox4.BackgroundImage = image;
                        break;
                    case 5:
                        pictureBox5.BackgroundImage = image;
                        break;
                    case 6:
                        pictureBox6.BackgroundImage = image;
                        break;
                    case 7:
                        pictureBox7.BackgroundImage = image;
                        break;
                    case 8:
                        pictureBox8.BackgroundImage = image;
                        break;
                    case 9:
                        pictureBox9.BackgroundImage = image;
                        break;
                    case 10:
                        pictureBox10.BackgroundImage = image;
                        break;
                    case 11:
                        pictureBox11.BackgroundImage = image;
                        break;
                    case 12:
                        pictureBox12.BackgroundImage = image;
                        break;
                }
            }
        }

        private Image getImageFromPath(string path)
        {
            switch(path)
            {
                case "1diabluemp":
                    return Resources._1_dia_blu_emp;
                case "1diabluhat":
                    return Resources._1_dia_blu_hat;
                case "1diablusol":
                    return Resources._1_dia_blu_sol;
                case "1diagreemp":
                    return Resources._1_dia_gre_emp;
                case "1diagrehat":
                    return Resources._1_dia_gre_hat;
                case "1diagresol":
                    return Resources._1_dia_gre_sol;
                case "1diaredemp":
                    return Resources._1_dia_red_emp;
                case "1diaredhat":
                    return Resources._1_dia_red_hat;
                case "1diaredsol":
                    return Resources._1_dia_red_sol;
                case "1ovabluemp":
                    return Resources._1_ova_blu_emp;
                case "1ovabluhat":
                    return Resources._1_ova_blu_hat;
                case "1ovablusol":
                    return Resources._1_ova_blu_sol;
                case "1ovagreemp":
                    return Resources._1_ova_gre_emp;
                case "1ovagrehat":
                    return Resources._1_ova_gre_hat;
                case "1ovagresol":
                    return Resources._1_ova_gre_sol;
                case "1ovaredemp":
                    return Resources._1_ova_red_emp;
                case "1ovaredhat":
                    return Resources._1_ova_red_hat;
                case "1ovaredsol":
                    return Resources._1_ova_red_sol;
                case "1squbluemp":
                    return Resources._1_squ_blu_emp;
                case "1squbluhat":
                    return Resources._1_squ_blu_hat;
                case "1squblusol":
                    return Resources._1_squ_blu_sol;
                case "1squgreemp":
                    return Resources._1_squ_gre_emp;
                case "1squgrehat":
                    return Resources._1_squ_gre_hat;
                case "1squgresol":
                    return Resources._1_squ_gre_sol;
                case "1squredemp":
                    return Resources._1_squ_red_emp;
                case "1squredhat":
                    return Resources._1_squ_red_hat;
                case "1squredsol":
                    return Resources._1_squ_red_sol;

                case "2diabluemp":
                    return Resources._2_dia_blu_emp;
                case "2diabluhat":
                    return Resources._2_dia_blu_hat;
                case "2diablusol":
                    return Resources._2_dia_blu_sol;
                case "2diagreemp":
                    return Resources._2_dia_gre_emp;
                case "2diagrehat":
                    return Resources._2_dia_gre_hat;
                case "2diagresol":
                    return Resources._2_dia_gre_sol;
                case "2diaredemp":
                    return Resources._2_dia_red_emp;
                case "2diaredhat":
                    return Resources._2_dia_red_hat;
                case "2diaredsol":
                    return Resources._2_dia_red_sol;
                case "2ovabluemp":
                    return Resources._2_ova_blu_emp;
                case "2ovabluhat":
                    return Resources._2_ova_blu_hat;
                case "2ovablusol":
                    return Resources._2_ova_blu_sol;
                case "2ovagreemp":
                    return Resources._2_ova_gre_emp;
                case "2ovagrehat":
                    return Resources._2_ova_gre_hat;
                case "2ovagresol":
                    return Resources._2_ova_gre_sol;
                case "2ovaredemp":
                    return Resources._2_ova_red_emp;
                case "2ovaredhat":
                    return Resources._2_ova_red_hat;
                case "2ovaredsol":
                    return Resources._2_ova_red_sol;
                case "2squbluemp":
                    return Resources._2_squ_blu_emp;
                case "2squbluhat":
                    return Resources._2_squ_blu_hat;
                case "2squblusol":
                    return Resources._2_squ_blu_sol;
                case "2squgreemp":
                    return Resources._2_squ_gre_emp;
                case "2squgrehat":
                    return Resources._2_squ_gre_hat;
                case "2squgresol":
                    return Resources._2_squ_gre_sol;
                case "2squredemp":
                    return Resources._2_squ_red_emp;
                case "2squredhat":
                    return Resources._2_squ_red_hat;
                case "2squredsol":
                    return Resources._2_squ_red_sol;

                case "3diabluemp":
                    return Resources._3_dia_blu_emp;
                case "3diabluhat":
                    return Resources._3_dia_blu_hat;
                case "3diablusol":
                    return Resources._3_dia_blu_sol;
                case "3diagreemp":
                    return Resources._3_dia_gre_emp;
                case "3diagrehat":
                    return Resources._3_dia_gre_hat;
                case "3diagresol":
                    return Resources._3_dia_gre_sol;
                case "3diaredemp":
                    return Resources._3_dia_red_emp;
                case "3diaredhat":
                    return Resources._3_dia_red_hat;
                case "3diaredsol":
                    return Resources._3_dia_red_sol;
                case "3ovabluemp":
                    return Resources._3_ova_blu_emp;
                case "3ovabluhat":
                    return Resources._3_ova_blu_hat;
                case "3ovablusol":
                    return Resources._3_ova_blu_sol;
                case "3ovagreemp":
                    return Resources._3_ova_gre_emp;
                case "3ovagrehat":
                    return Resources._3_ova_gre_hat;
                case "3ovagresol":
                    return Resources._3_ova_gre_sol;
                case "3ovaredemp":
                    return Resources._3_ova_red_emp;
                case "3ovaredhat":
                    return Resources._3_ova_red_hat;
                case "3ovaredsol":
                    return Resources._3_ova_red_sol;
                case "3squbluemp":
                    return Resources._3_squ_blu_emp;
                case "3squbluhat":
                    return Resources._3_squ_blu_hat;
                case "3squblusol":
                    return Resources._3_squ_blu_sol;
                case "3squgreemp":
                    return Resources._3_squ_gre_emp;
                case "3squgrehat":
                    return Resources._3_squ_gre_hat;
                case "3squgresol":
                    return Resources._3_squ_gre_sol;
                case "3squredemp":
                    return Resources._3_squ_red_emp;
                case "3squredhat":
                    return Resources._3_squ_red_hat;
                case "3squredsol":
                    return Resources._3_squ_red_sol;

                default:
                    return Resources.Error;

            }
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
            GeneralOptions options = new GeneralOptions();
            options.ShowDialog();
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
                currentSet.Remove(cardsOnBoard[0]);
                --cardsSelected;
            }
            else if (cardsSelected < 3)
            {
                pictureBox1.BackColor = Color.Gold;
                currentSet.Add(cardsOnBoard[0]);
                ++cardsSelected;
            }
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
                currentSet.Remove(cardsOnBoard[1]);
                --cardsSelected;
            }
            else if (cardsSelected < 3)
            {
                pictureBox2.BackColor = Color.Gold;
                currentSet.Add(cardsOnBoard[1]);
                ++cardsSelected;
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
                currentSet.Remove(cardsOnBoard[2]);
                --cardsSelected;
            }
            else if (cardsSelected < 3)
            {
                pictureBox3.BackColor = Color.Gold;
                currentSet.Add(cardsOnBoard[2]);
                ++cardsSelected;
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
                currentSet.Remove(cardsOnBoard[3]);
                --cardsSelected;
            }
            else if (cardsSelected < 3)
            {
                pictureBox4.BackColor = Color.Gold;
                currentSet.Add(cardsOnBoard[3]);
                ++cardsSelected;
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
                currentSet.Remove(cardsOnBoard[4]);
                --cardsSelected;
            }
            else if (cardsSelected < 3)
            {
                pictureBox5.BackColor = Color.Gold;
                currentSet.Add(cardsOnBoard[4]);
                ++cardsSelected;
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
                currentSet.Remove(cardsOnBoard[5]);
                --cardsSelected;
            }
            else if (cardsSelected < 3)
            {
                pictureBox6.BackColor = Color.Gold;
                currentSet.Add(cardsOnBoard[5]);
                ++cardsSelected;
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
                currentSet.Remove(cardsOnBoard[6]);
                --cardsSelected;
            }
            else if (cardsSelected < 3)
            {
                pictureBox7.BackColor = Color.Gold;
                currentSet.Add(cardsOnBoard[6]);
                ++cardsSelected;
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
                currentSet.Remove(cardsOnBoard[7]);
                --cardsSelected;
            }
            else if (cardsSelected < 3)
            {
                pictureBox8.BackColor = Color.Gold;
                currentSet.Add(cardsOnBoard[7]);
                ++cardsSelected;
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
                currentSet.Remove(cardsOnBoard[8]);
                --cardsSelected;
            }
            else if (cardsSelected < 3)
            {
                pictureBox9.BackColor = Color.Gold;
                currentSet.Add(cardsOnBoard[8]);
                ++cardsSelected;
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
                currentSet.Remove(cardsOnBoard[9]);
                --cardsSelected;
            }
            else if (cardsSelected < 3)
            {
                pictureBox10.BackColor = Color.Gold;
                currentSet.Add(cardsOnBoard[9]);
                ++cardsSelected;
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
                currentSet.Remove(cardsOnBoard[10]);
                --cardsSelected;
            }
            else if (cardsSelected < 3)
            {
                pictureBox11.BackColor = Color.Gold;
                currentSet.Add(cardsOnBoard[10]);
                ++cardsSelected;
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
                currentSet.Remove(cardsOnBoard[11]);
                --cardsSelected;
            }
            else if (cardsSelected < 3)
            {
                pictureBox12.BackColor = Color.Gold;
                currentSet.Add(cardsOnBoard[11]);
                ++cardsSelected;
            }
        }
    }
}