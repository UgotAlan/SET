namespace SET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This class contains variables which can hold every element
    /// needed to properly describe a player for the game SET.
    /// All variables are public and contain getters/setters.
    /// </summary>
    public class Players
    {
        /// <summary>
        /// Initializes a new instance of the Players class.
        /// This sets every string variable to empty, each 
        /// integer to 0, and each boolean to false.
        /// </summary>
        public Players()
        {
            IsHost = true;
            NumberOfPlayers = 1;
            Mute = false;
            Score = 0;
            SetsMade = new List<List<Cards>>();
            Keybinds = new Dictionary<char, char>();
        }

        /// <summary>
        /// This variable contains a boolean to know
        /// if a player is the host.
        /// </summary>
        public bool IsHost { get; set; }

        /// <summary>
        /// This variable contains an integer to know
        /// how many players are in the user's game.
        /// </summary>
        public int NumberOfPlayers { get; set; }

        /// <summary>
        /// This variable contains a List to hold Sets
        /// of Cards made by the player.
        /// </summary>
        public List<List<Cards>> SetsMade { get; set; }

        /// <summary>
        /// This variable contains a boolean to know
        /// if a player has muted the game.
        /// </summary>
        public bool Mute { get; set; }

        /// <summary>
        /// This variable contains a dictionary to hold
        /// the key binds made by the player.
        /// </summary>
        public Dictionary<char, char> Keybinds { get; set; }

        /// <summary>
        /// This variable contains an integer to
        /// store the player's score.
        /// </summary>
        public int Score { get; set; }

        internal void addSet(List<Cards> cardList)
        {
            this.SetsMade.Add(cardList);
        }
    }
}