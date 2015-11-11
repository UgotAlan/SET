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
        public Lobby()
        {
            InitializeComponent();
        }
    }
}
