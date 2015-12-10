namespace SET
{
    using Properties;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This class contains variables which can hold every element
    /// needed for the Processing.cs class.
    /// </summary>
    class Data
    {
        // Make initializers for each variable in a constructor.
        private List<Cards> deck;
        private List<Players> players;
        private List<Cards> cardsOnBoard;
        private bool colorMode;
        private bool beginnerMode;
        private bool tutorialMode;
        private int numberOfSets;

        public Data()
        {
            deck = new List<Cards>();
            players = new List<Players>();
            players.Add(new Players());
            cardsOnBoard = new List<Cards>();
            colorMode = false;
            beginnerMode = false;
            tutorialMode = false;
            numberOfSets = 10;
        }

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
        
        public void buildDeck()
        {
            string shape = "temp";
            string color = "temp";
            string shade = "temp";
            
            for (var number = 1; number <= 3; ++number)
            {
                for (var b = 0; b < 3; ++b)
                {
                    switch(b)
                    {
                        case 0:
                            shape = "dia";
                            break;
                        case 1:
                            shape = "ova";
                            break;
                        case 2:
                            shape = "squ";
                            break;
                    }
                    for (var c = 0; c < 3; ++c)
                    {
                        switch (c)
                        {
                            case 0:
                                color = "blu";
                                break;
                            case 1:
                                color = "gre";
                                break;
                            case 2:
                                color = "red";
                                break;
                        }
                        for (var d = 0; d < 3; ++d)
                        {
                            switch(d)
                            {
                                case 0:
                                    shade = "emp";
                                    break;
                                case 1:
                                    shade = "hat";
                                    break;
                                case 2:
                                    shade = "sol";
                                    break;
                            }
                            string path = number + shape + color + shade;
                            Cards card = new Cards(path, color, shade, shape, number);
                            deck.Add(card);
                        }
                    }
                }
            }

            shuffleDeck();
            for (int i = 0; i < 12; ++i)
                getNewCard();
        }
        
        public List<Cards> getCardsOnBoard()
        {
            return cardsOnBoard;
        }
        
        public int getUsers()
        {
            return players.Count;
        }
        
        public int getUserScore()
        {
            return players[0].Score;
        }
        
        public void setUserScore(int score)
        {
            players[0].Score = score;
        }

        public bool checkFinish()
        {
            if (getUserScore() == numberOfSets)
                return true;
            return false;
        }
        
        public List<List<Cards>> getUserSets()
        {
            return players[0].SetsMade;
        }
        
        public Cards getNewCard()
        {
            List<Cards> templist = new List<Cards>();
            foreach (Cards card in deck)
            {
                if (!card.BeenPlayed && !card.Inplay)
                {
                    card.Inplay = true;
                    cardsOnBoard.Add(card);
                    if (cardsOnBoard.Count != 12 || CheckSetOnBoard(cardsOnBoard))
                    {
                        foreach (Cards temp in templist)
                            temp.Inplay = false;
                        return card;
                    }
                    else
                    {
                        cardsOnBoard.Remove(card);
                        templist.Add(card);
                    }
                }
            }
            return new Cards();
        }

        private bool CheckSetOnBoard(List<Cards> listTwelve)
        {
            List<Cards> listThree = new List<Cards>();

            Cards card1 = new Cards();
            Cards card2 = new Cards();
            Cards card3 = new Cards();

            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0; j < 12; ++j)
                {
                    if (j != i)
                    {
                        for (int k = 0; k < 12; ++k)
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
                                if (CheckSet(listThree) == true)
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

        public void removeCardsFromPlay(List<Cards> cardList)
        {
            foreach (Cards card in cardList)
            {
                card.Inplay = false;
                card.BeenPlayed = true;
                cardsOnBoard.Remove(card);
            }
        }
        
        public void removePlayedFlags()
        {
            foreach (Cards card in deck)
                card.BeenPlayed = false;
        }

        public void shuffleDeck()
        {
            List <Cards> newDeck = new List<Cards>();
            Random rand = new Random();
            for (int i = 81; i > 0; --i)
            {
                int card = rand.Next(0, i);
                newDeck.Add(deck.ElementAt(card));
                deck.RemoveAt(card);
            }

            deck = newDeck;
        }
        
        /// <summary>
        /// Loops through all possible combinations of 3 cards form the game board to find if
        /// there is at least one possible set by using method confirmSet.
        /// </summary>
        /// <param name="listTwelve">Argument takes List type</param>
        /// <returns>boolean true/false</returns>
        public bool CheckSet(List<Cards> cardList)
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
                players[0].addSet(cardList);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
