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
        /// <summary>
        /// Initializes a new instance of the GameBoard class.
        /// </summary>
        public GameBoard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for user clicking the button labeled set.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void SetButtonClick(object sender, EventArgs e)
        {
            // Set Logic
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
        }

        /// <summary>
        /// Event handler for user click on the button labeled exit.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void ExitButtonClick(object sender, EventArgs e)
        {
            // Bring up exit dialog
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
    }
}