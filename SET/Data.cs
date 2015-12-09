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
        private List<Cards> cardOnBoard;
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
                            string path = "_" + number + "_" + shape + "_" + color + "_" + shade;
                            deck.Add(new Cards(path, color, shade, shape, number));
                        }
                    }
                }
            }
        }
        
        public List<Cards> getCardsOnBoard()
        {
            return cardOnBoard;
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
            foreach (Cards card in deck)
            {
                if (!card.BeenPlayed)
                {
                    card.Inplay = true;
                    cardOnBoard.Add(card);
                    return card;
                }
            }
            return new Cards();
        }

        public void removeCardsFromPlay(List<Cards> cardList)
        {
            foreach (Cards card in cardList)
            {
                card.Inplay = false;
                cardOnBoard.Remove(card);
            }
        }
        
        public void removePlayedFlags()
        {
            foreach (Cards card in deck)
                card.BeenPlayed = false;
        }

        public void shuffleDeck()
        {
            var shuffledcards = deck.OrderBy(a => Guid.NewGuid());
        }
    }
}
