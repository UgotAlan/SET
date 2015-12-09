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
            else // this will defualt to normal mode
            {
                gameData.changeNormalMode();
            }

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

        public int getUserScore(int v)
        {
            return gameData.getUserScore(v);
        }

        public void setUserScore(int player, int score)
        {
            gameData.setUserScore(player, score);
        }

        public List<List<Cards>> getUserSets()
        {
            return gameData.getUserSets();
        }

        public Cards[] getCardsOnBoard()
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

        /// <summary>
        /// Loops through all possible combinations of 3 cards form the game board to find if
        /// there is at least one possible set by using method confirmSet.
        /// </summary>
        /// <param name="listTwelve">Argument takes List type</param>
        /// <returns>boolean true/false</returns>
        public bool CheckSet(List<Cards> listTwelve)
        {
            List<Cards> listThree = new List<Cards>();

            Cards card1 = new Cards();
            Cards card2 = new Cards();
            Cards card3 = new Cards();

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (j != i)
                    {
                        for (int k = 0; k < 12; k++)
                        {
                            if (k != i && k != j)
                            {
                                listThree.Clear();

                                card1.Color = listTwelve.ElementAt(i).Color;
                                card1.Number = listTwelve.ElementAt(i).Number;
                                card1.Shade = listTwelve.ElementAt(i).Shade;
                                card1.Shape = listTwelve.ElementAt(i).Shape;

                                card2.Color = listTwelve.ElementAt(j).Color;
                                card2.Number = listTwelve.ElementAt(j).Number;
                                card2.Shade = listTwelve.ElementAt(j).Shade;
                                card2.Shape = listTwelve.ElementAt(j).Shape;

                                card3.Color = listTwelve.ElementAt(k).Color;
                                card3.Number = listTwelve.ElementAt(k).Number;
                                card3.Shade = listTwelve.ElementAt(k).Shade;
                                card3.Shape = listTwelve.ElementAt(k).Shape;

                                listThree.Insert(0, card1);
                                listThree.Insert(1, card2);
                                listThree.Insert(2, card3);

                                // If the current combination is a set, return true and exit the method.
                                if (ConfirmSet(listThree) == true)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            // Return false if there are no possible SET combinations on the gameboard.
            return false;
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
