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
    public class Processing
    {
        private Data gameData = new Data();

        public void startGame(int[] options)
        {
            setOptions(options);
            gameData.setUsers(1);
            createDeck();
            getCardsOnBoard();
        }

        private void setOptions(int[] options)
        {
            if (options[0] == 0)
            {
                gameData.changeColorMode();
            }
            else if (options[0] == 1)
            {
                gameData.changeBeginnerMode();
            }
            else if (options[0] == 2)
            {
                gameData.changeTutorialMode();
            }
            else 
            {
                // this will defualt to normal mode
            }

            gameData.changeNumberOfSets(options[1]);
        }

        private void createDeck()
        {
            gameData.buildDeck();
            ShuffleDeck();
        }

        public int getNumberUsers()
        {
            return gameData.getUsers();
        }

        public int getUserScore()
        {
            return gameData.getUserScore();
        }

        public void setUserScore(int score)
        {
            gameData.setUserScore(score);
        }

        public List<List<Cards>> getUserSets()
        {
            return gameData.getUserSets();
        }

        public void setUserSets(List<Cards> set)
        {
            gameData.setUserSets(set);
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
            if (CheckSet(cardList))
            {
                gameData.setUserScore(1);
                if (!CheckFinish())
                {
                    gameData.removeCardsFromPlay(cardList);
                    for (var i = 0; i < 3; ++i)
                    {
                        if (gameData.getNewCard() == false)
                            gameData.shuffleDeck();
                    }
                }
                return true;
            }
            else
            {
                gameData.setUserScore(- 1);
                return false;
            }
        }

        /// <summary>
        /// Loops through all possible combinations of 3 cards form the game board to find if
        /// there is at least one possible set by using method confirmSet.
        /// </summary>
        /// <param name="listTwelve">Argument takes List type</param>
        /// <returns>boolean true/false</returns>
        private bool CheckSet(List<Cards> cardList)
        {
            // true if valid set, false if invalid
            int counter = 0;

            // sort list by field type (color/number/shade/shape)
            cardList.Sort((x, y) => x.Color.CompareTo(y.Color));

            // check if color, number, shade, and shape between all 3 cards are the same or all different
            if (cardList.ElementAt(0).Color == cardList.ElementAt(1).Color && cardList.ElementAt(1).Color == cardList.ElementAt(2).Color)
            {
                counter++;
            }
            else if (cardList.ElementAt(0).Color != cardList.ElementAt(1).Color && cardList.ElementAt(1).Color != cardList.ElementAt(2).Color)
            {
                counter++;
            }

            cardList.Sort((x, y) => x.Number.CompareTo(y.Number));

            if (cardList.ElementAt(0).Number == cardList.ElementAt(1).Number && cardList.ElementAt(1).Number == cardList.ElementAt(2).Number)
            {
                counter++;
            }
            else if (cardList.ElementAt(0).Number != cardList.ElementAt(1).Number && cardList.ElementAt(1).Number != cardList.ElementAt(2).Number)
            {
                counter++;
            }

            cardList.Sort((x, y) => x.Shade.CompareTo(y.Shade));

            if (cardList.ElementAt(0).Shade == cardList.ElementAt(1).Shade && cardList.ElementAt(1).Shade == cardList.ElementAt(2).Shade)
            {
                counter++;
            }
            else if (cardList.ElementAt(0).Shade != cardList.ElementAt(1).Shade && cardList.ElementAt(1).Shade != cardList.ElementAt(2).Shade)
            {
                counter++;
            }

            cardList.Sort((x, y) => x.Shape.CompareTo(y.Shape));

            if (cardList.ElementAt(0).Shape == cardList.ElementAt(1).Shape && cardList.ElementAt(1).Shape == cardList.ElementAt(2).Shape)
            {
                counter++;
            }
            else if (cardList.ElementAt(0).Shape != cardList.ElementAt(1).Shape && cardList.ElementAt(1).Shape != cardList.ElementAt(2).Shape)
            {
                counter++;
            }

            // check to see if all 4 stipulations to make a set have been satisfied
            if (counter == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool CheckFinish()
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
