namespace SET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This class contains variables which can hold every element
    /// needed to properly describe a card of the game SET.
    /// All variables are public and contain getters/setters.
    /// </summary>
    public class Cards
    {
        /// <summary>
        /// Initializes a new instance of the Cards class.
        /// This sets every string variable to empty, each 
        /// integer to 0, and each boolean to false.
        /// </summary>
        public Cards()
        {
            Image = string.Empty;
            Color = string.Empty;
            Shade = string.Empty;
            Shape = string.Empty;
            Number = 0;
            Inplay = false;
            BeenPlayed = false;
        }

        public Cards(int number, string color, string shade, string shape)
        {
            this.Number = number;
            this.Color = color;
            this.Shade = shade;
            this.Shape = shape;
            this.Image = "../../../set_cards/" + this.Number.ToString() + "_" + this.Shape + "_" + this.Color + "_" + this.Shade + ".gif";
        }

        /// <summary>
        /// This variable contains a string for the image path 
        /// to the card's visual.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// This variable contains a string for the color
        /// of the card.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// This variable contains a string for the shade
        /// of the card.
        /// </summary>
        public string Shade { get; set; }

        /// <summary>
        /// This variable contains a string for the shape
        /// of the card.
        /// </summary>
        public string Shape { get; set; }

        /// <summary>
        /// This variable contains an integer for the
        /// number of shapes present on the card.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// This variable contains a boolean so the card
        /// knows whether or not it is currently on the
        /// game board.
        /// </summary>
        public bool Inplay { get; set; }

        /// <summary>
        /// This variable contains a boolean so the card
        /// knows whether or not it has been played
        /// since the last time the deck has been shuffled.
        /// </summary>
        public bool BeenPlayed { get; set; }
    }
}
