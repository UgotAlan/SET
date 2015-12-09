namespace SET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// This form displays a menu where users
    /// can start a single player game, multi
    /// player game, change options, or exit
    /// the game.
    /// </summary>
    public partial class MainMenu : Form
    {
        public Players player1 = new Players();
        
        /// <summary>
        /// Initializes a new instance of the MainMenu class.
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void OptionsLabel_Click(object sender, EventArgs e)
        {
            // make GeneralOptions Form come to top.
            GeneralOptions options = new GeneralOptions(player1);
            options.ShowDialog();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            // exit from the mainMenu form
            this.Close();
        }

        private void MultiPlayerLabel_Click(object sender, EventArgs e)
        {
            // Test Ping and Ram. If both pass, hide main menu and make lobby finder form.
            TestPingAndRam pingRamTest = new TestPingAndRam();
            long max_ping = 300;
            string ip = "www.google.com";
            var ramC = new PerformanceCounter("Memory", "Available MBytes");

            if (pingRamTest.CheckPing(max_ping, ip) == true)
            {
                if (pingRamTest.CheckRam(ramC.NextValue()) == true)
                {
                    // hide main menu
                    this.Hide();

                    // make lobby finder form.
                    LobbyFinder lobbyFinder = new LobbyFinder();
                    lobbyFinder.ShowDialog();
                    this.Show(); 
                }
                else
                {
                    MessageBox.Show("NOT ENOUGH AVAILABLE RAM MEMORY!!!");
                }
            }
            else
            {
                MessageBox.Show("NETWORK CONNECTION FAILED!!! ERROR(Ping Test)");
            }
        }

        private void SinglePlayerLabel_Click(object sender, EventArgs e)
        {
            TestPingAndRam ramTest = new TestPingAndRam();
            var ramC = new PerformanceCounter("Memory", "Available MBytes");

            if (ramTest.CheckRam(ramC.NextValue()) == true)
            {
                // hide the main menu
                this.Hide();

                // send user to the lobby
                Lobby lobby = new Lobby();
                lobby.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("NOT ENOUGH AVAILABLE RAM MEMORY!!!");
            }
        }

        private void SinglePlayerLabel_MouseEnter(object sender, EventArgs e)
        {
            singlePlayerLabel.ForeColor = Color.LightGray;
        }

        private void SinglePlayerLabel_MouseLeave(object sender, EventArgs e)
        {
            singlePlayerLabel.ForeColor = Color.White;
        }

        private void MultiPlayerLabel_MouseLeave(object sender, EventArgs e)
        {
            multiPlayerLabel.ForeColor = Color.White;
        }

        private void MultiPlayerLabel_MouseEnter(object sender, EventArgs e)
        {
            multiPlayerLabel.ForeColor = Color.LightGray;
        }

        private void OptionsLabel_MouseLeave(object sender, EventArgs e)
        {
            optionsLabel.ForeColor = Color.White;
        }

        private void OptionsLabel_MouseEnter(object sender, EventArgs e)
        {
            optionsLabel.ForeColor = Color.LightGray;
        }

        private void ExitLabel_MouseEnter(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.LightGray;
        }

        private void ExitLabel_MouseLeave(object sender, EventArgs e)
        {
            exitLabel.ForeColor = Color.White;
        }
    }
}
