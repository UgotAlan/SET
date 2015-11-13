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
    /// This Form displays a lobby to the User where
    /// they can change options which affects how the
    /// game is made, and run. They can also quit the
    /// lobby, or start the game. The User can also see
    /// every other User that is connected to the same
    /// game lobby.
    /// </summary>
    public partial class Lobby : Form
    {
        /// <summary>
        /// Initializes a new instance of the Lobby class.
        /// </summary>
        public Lobby()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for user click on startLabel.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void StartLabelClick(object sender, EventArgs e)
        {
            // Logic for starting game.
        }

        /// <summary>
        /// Event handler for user click on quitLabel.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void QuitLabelClick(object sender, EventArgs e)
        {
            // Logic for quitting lobby.
        }

        /// <summary>
        /// Event handler for user hover over startLabel.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void StartLabelMouseEnter(object sender, EventArgs e)
        {
            startLabel.ForeColor = Color.LightGray;
        }

        /// <summary>
        /// Event handler for user leaving startLabel.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void StartLabelMouseLeave(object sender, EventArgs e)
        {
            startLabel.ForeColor = Color.White;
        }

        /// <summary>
        /// Event handler for user hovering over quitLabel.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void QuitLabelMouseEnter(object sender, EventArgs e)
        {
            quitLabel.ForeColor = Color.LightGray;
        }

        /// <summary>
        /// Event handler for user leaving quitLabel.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void QuitLabelMouseLeave(object sender, EventArgs e)
        {
            quitLabel.ForeColor = Color.White;
        }
    }
}
