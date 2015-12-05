namespace SET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This class contains variables which can hold every element
    /// needed for the Processing.cs class.
    /// </summary>
    class Data
    {
        // Make initializers for each variable in a constructor.
        private Queue<Cards> deck;
        private List<Players> players;
        private Cards[] cardsOnBoard; // Remember to put 'cardsOnBoard = new Cards[12];'  in the constructor.
        private bool colorMode;
        private bool beginnerMode;
        private bool tutorialMode;
        private int numberOfSets;

        public void changeColorMode()
        {
            colorMode = true;
        }

        public void changeBeginnerMode()
        {
            beginnerMode = true;
        }

        public void changeTutorialMode()
        {
            tutorialMode = true;
        }

        public void changeNumberOfSets(int sets)
        {
            numberOfSets = sets;
        }

        // Unfinished
        public void buildDeck()
        {

        }

        // Unfinished
        public Cards[] getCardsOnBoard()
        {
            return null;
        }

        // Unfinished
        public int getUsers()
        {
            return 0;
        }

        // Unfinished
        public int getUserScore()
        {
            return 0;
        }

        // Unfinished
        public void setUserScore(int score)
        {

        }

        // Unfinished
        public List<List<Cards>> getUserSets()
        {
            return null;
        }

        // Unfinished
        public Cards getNewCard()
        {
            return null;
        }

        // Unfinished
        public void removePlayedFlags()
        {
            
        }

        // Unfinished
        public void shuffleDeck()
        {

        }
    }
}
