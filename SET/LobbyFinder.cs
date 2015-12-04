namespace SET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
    using System.Net.NetworkInformation;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// This Form displays a list of lobbies able to be
    /// joined by the user. The User can join an existing
    /// lobby, create one, or exit to the main menu.
    /// </summary>
    public partial class LobbyFinder : Form
    {
        /// <summary>
        /// Initializes a new instance of the LobbyFinder class.
        /// </summary>
        public LobbyFinder()
        {
            InitializeComponent();
            Ping p = new Ping();
            var ramC = new PerformanceCounter("Memory", "Available MBytes");
            pingResult.Text = p.Send("www.google.com").RoundtripTime.ToString() + " ms";
            ramResult.Text = ramC.NextValue().ToString() + " MB";
        }

        /// <summary>
        /// Event handler for user click on joinLabel.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void JoinLabelClick(object sender, EventArgs e)
        {
            // Logic for joining a lobby.
            this.Hide();
            Lobby lobby = new Lobby();
            lobby.ShowDialog();
        }

        /// <summary>
        /// Event handler for user click on createLabel.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CreateLabelClick(object sender, EventArgs e)
        {
            // Logic for creating a lobby.
            this.Hide();
            Lobby lobby = new Lobby();
            lobby.ShowDialog();
        }

        /// <summary>
        /// Event handler for user click on exitLabel.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void ExitLabelClick(object sender, EventArgs e)
        {
            // Logic for going back to main menu
            this.Close();
        }

        /// <summary>
        /// Event handler for user hovering over joinLabel.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void JoinLabelMouseEnter(object sender, EventArgs e)
        {
            joinLabel.ForeColor = Color.LightGray;
        }

        /// <summary>
        /// Event handler for user leaving joinLabel.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void JoinLabelMouseLeave(object sender, EventArgs e)
        {
            joinLabel.ForeColor = Color.White;
        }

        /// <summary>
        /// Event handler for user hovering over createLabel.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CreateLabelMouseEnter(object sender, EventArgs e)
        {
            createLabel.ForeColor = Color.LightGray;
        }

        /// <summary>
        /// Event handler for user leaving createLabel.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CreateLabelMouseLeave(object sender, EventArgs e)
        {
            createLabel.ForeColor = Color.White;
        }

        /// <summary>
        /// Event handler for user hovering over exitLabel.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void ExitLabelMouseEnter(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.LightGray;
        }

        /// <summary>
        /// Event handler for user leaving exitLabel.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void ExitLabelMouseLeave(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.White;
        }
    }
}
