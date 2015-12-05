namespace SET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This class contains variables which can hold every element
    /// and method relating to processing instructions from the
    /// GameBoard.cs class and Data.cs class.
    /// </summary>
    class Processing
    {
        private Data gameData = new Data();

        public void startGame(int[] options)
        {
            setOptions(options);
            createDeck();
        }

        private void setOptions(int[] options)
        {
            if (options[0] == 0)
                gameData.changeColorMode();
            else if (options[0] == 1)
                gameData.changeBeginnerMode();
            else if (options[0] == 2)
                gameData.changeTutorialMode();
            else if (options[0] == 3)
                gameData.changeTutorialMode();
            gameData.changeNumberOfSets(options[1]);
        }

        private void createDeck()
        {
            gameData.buildDeck();
        }

        public int getNumberUsers()
        {
            return gameData.getUsers();
        }

        public int getUserScore()
        {
            return gameData.getUserScore();
        }

        public List<List<Cards>> getUserSets()
        {
            return gameData.getUserSets();
        }

        public Cards[] getCardsOnBoard()
        {
            return gameData.getCardsOnBoard();
        }

        // Unfinished
        public bool confirmSet()
        {
            // true if valid set, false if invalid
            return true;
        }

        // Unfinished
        public bool checkSet(Cards[] set)
        {
            return true;
        }

        // Unfinished
        private bool checkFinish()
        {
            return false;
        }

        // Unfinished
        private void shuffleDeck()
        {

        }
    }
}
