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
        }
    }
}
