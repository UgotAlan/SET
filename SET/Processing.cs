namespace SET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// This class contains variables which can hold every element
    /// and method relating to processing instructions from the
    /// GameBoard.cs class and Data.cs class.
    /// </summary>
    public class Processing
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

        public List<Cards> getCardsOnBoard()
        {
            return gameData.getCardsOnBoard();
        }

        /// <summary>
        /// method confirms whether three chosen cards are an actual set
        /// after selecting 3 cards and pressing the set button.
        /// </summary>
        /// <param name="cardList">Argument takes List type</param>
        /// <returns>boolean true/false</returns>
        public bool ConfirmSet(List<Cards> cardList)
        {
            if (gameData.CheckSet(cardList))
            {
                gameData.setUserScore(getUserScore() + 1);
                if (CheckFinish())
                {
                    // Win condition
                    MessageBox.Show("Player 1 won the game!");
                    return false;
                }
                else
                {
                    gameData.removeCardsFromPlay(cardList);
                    for (var i = 0; i < 3; ++i)
                    {
                        if (gameData.getNewCard() == new Cards())
                            gameData.shuffleDeck();
                    }
                    return true;
                }
            }
            else
            {
                gameData.setUserScore(getUserScore() - 1);
                return false;
            }
        }
        
        private bool CheckFinish()
        {
            if (gameData.checkFinish())
                return true;
            return false;
        }
        
        private void ShuffleDeck()
        {
            gameData.shuffleDeck();
        }
    }
}
