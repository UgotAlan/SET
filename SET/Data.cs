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
        private Queue<Cards> deck = new Queue<Cards>();
        private List<Players> players = new List<Players>();
        private Cards[] cardsOnBoard = new Cards[12]; // Remember to put 'cardsOnBoard = new Cards[12];'  in the constructor.
        private bool colorMode;
        private bool beginnerMode;
        private bool tutorialMode;
        private bool normalMode;
        private int numberOfSets;
        private int numCardsOnBoard = 0;

        public void changeNormalMode()
        {
            tutorialMode = true;
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

        public void setUsers(int v)
        {
            // right now just set users to 1
            Players player1 = new Players();
            players.Add(player1);
        }

        // Unfinished
        public void buildDeck()
        {
            Cards card1 = new Cards(1, "blu", "emp", "dia");
            Cards card2 = new Cards(1, "blu", "hat", "dia");
            Cards card3 = new Cards(1, "blu", "sol", "dia");
            Cards card4 = new Cards(1, "gre", "emp", "dia");
            Cards card5 = new Cards(1, "gre", "hat", "dia");
            Cards card6 = new Cards(1, "gre", "sol", "dia");
            Cards card7 = new Cards(1, "red", "emp", "dia");
            Cards card8 = new Cards(1, "red", "hat", "dia");
            Cards card9 = new Cards(1, "red", "sol", "dia");
            Cards card10 = new Cards(1, "blu", "emp", "ova");
            Cards card11 = new Cards(1, "blu", "hat", "ova");
            Cards card12 = new Cards(1, "blu", "sol", "ova");
            Cards card13 = new Cards(1, "gre", "emp", "ova");
            Cards card14 = new Cards(1, "gre", "hat", "ova");
            Cards card15 = new Cards(1, "gre", "sol", "ova");
            Cards card16 = new Cards(1, "red", "emp", "ova");
            Cards card17 = new Cards(1, "red", "hat", "ova");
            Cards card18 = new Cards(1, "red", "sol", "ova");
            Cards card19 = new Cards(1, "blu", "emp", "squ");
            Cards card20 = new Cards(1, "blu", "hat", "squ");
            Cards card21 = new Cards(1, "blu", "sol", "squ");
            Cards card22 = new Cards(1, "gre", "emp", "squ");
            Cards card23 = new Cards(1, "gre", "hat", "squ");
            Cards card24 = new Cards(1, "gre", "sol", "squ");
            Cards card25 = new Cards(1, "red", "emp", "squ");
            Cards card26 = new Cards(1, "red", "hat", "squ");
            Cards card27 = new Cards(1, "red", "sol", "squ");
            Cards card28 = new Cards(2, "blu", "emp", "dia");
            Cards card29 = new Cards(2, "blu", "hat", "dia");
            Cards card30 = new Cards(2, "blu", "sol", "dia");
            Cards card31 = new Cards(2, "gre", "emp", "dia");
            Cards card32 = new Cards(2, "gre", "hat", "dia");
            Cards card33 = new Cards(2, "gre", "sol", "dia");
            Cards card34 = new Cards(2, "red", "emp", "dia");
            Cards card35 = new Cards(2, "red", "hat", "dia");
            Cards card36 = new Cards(2, "red", "sol", "dia");
            Cards card37 = new Cards(2, "blu", "emp", "ova");
            Cards card38 = new Cards(2, "blu", "hat", "ova");
            Cards card39 = new Cards(2, "blu", "sol", "ova");
            Cards card40 = new Cards(2, "gre", "emp", "ova");
            Cards card41 = new Cards(2, "gre", "hat", "ova");
            Cards card42 = new Cards(2, "gre", "sol", "ova");
            Cards card43 = new Cards(2, "red", "emp", "ova");
            Cards card44 = new Cards(2, "red", "hat", "ova");
            Cards card45 = new Cards(2, "red", "sol", "ova");
            Cards card46 = new Cards(2, "blu", "emp", "squ");
            Cards card47 = new Cards(2, "blu", "hat", "squ");
            Cards card48 = new Cards(2, "blu", "sol", "squ");
            Cards card49 = new Cards(2, "gre", "emp", "squ");
            Cards card50 = new Cards(2, "gre", "hat", "squ");
            Cards card51 = new Cards(2, "gre", "sol", "squ");
            Cards card52 = new Cards(2, "red", "emp", "squ");
            Cards card53 = new Cards(2, "red", "hat", "squ");
            Cards card54 = new Cards(2, "red", "sol", "squ");
            Cards card55 = new Cards(3, "blu", "emp", "dia");
            Cards card56 = new Cards(3, "blu", "hat", "dia");
            Cards card57 = new Cards(3, "blu", "sol", "dia");
            Cards card58 = new Cards(3, "gre", "emp", "dia");
            Cards card59 = new Cards(3, "gre", "hat", "dia");
            Cards card60 = new Cards(3, "gre", "sol", "dia");
            Cards card61 = new Cards(3, "red", "emp", "dia");
            Cards card62 = new Cards(3, "red", "hat", "dia");
            Cards card63 = new Cards(3, "red", "sol", "dia");
            Cards card64 = new Cards(3, "blu", "emp", "ova");
            Cards card65 = new Cards(3, "blu", "hat", "ova");
            Cards card66 = new Cards(3, "blu", "sol", "ova");
            Cards card67 = new Cards(3, "gre", "emp", "ova");
            Cards card68 = new Cards(3, "gre", "hat", "ova");
            Cards card69 = new Cards(3, "gre", "sol", "ova");
            Cards card70 = new Cards(3, "red", "emp", "ova");
            Cards card71 = new Cards(3, "red", "hat", "ova");
            Cards card72 = new Cards(3, "red", "sol", "ova");
            Cards card73 = new Cards(3, "blu", "emp", "squ");
            Cards card74 = new Cards(3, "blu", "hat", "squ");
            Cards card75 = new Cards(3, "blu", "sol", "squ");
            Cards card76 = new Cards(3, "gre", "emp", "squ");
            Cards card77 = new Cards(3, "gre", "hat", "squ");
            Cards card78 = new Cards(3, "gre", "sol", "squ");
            Cards card79 = new Cards(3, "red", "emp", "squ");
            Cards card80 = new Cards(3, "red", "hat", "squ");
            Cards card81 = new Cards(3, "red", "sol", "squ");

            deck.Enqueue(card1);
            deck.Enqueue(card2);
            deck.Enqueue(card3);
            deck.Enqueue(card4);
            deck.Enqueue(card5);
            deck.Enqueue(card6);
            deck.Enqueue(card7);
            deck.Enqueue(card8);
            deck.Enqueue(card9);
            deck.Enqueue(card10);
            deck.Enqueue(card11);
            deck.Enqueue(card12);
            deck.Enqueue(card13);
            deck.Enqueue(card14);
            deck.Enqueue(card15);
            deck.Enqueue(card16);
            deck.Enqueue(card17);
            deck.Enqueue(card18);
            deck.Enqueue(card19);
            deck.Enqueue(card20);
            deck.Enqueue(card21);
            deck.Enqueue(card22);
            deck.Enqueue(card23);
            deck.Enqueue(card24);
            deck.Enqueue(card25);
            deck.Enqueue(card26);
            deck.Enqueue(card27);
            deck.Enqueue(card28);
            deck.Enqueue(card29);
            deck.Enqueue(card30);
            deck.Enqueue(card31);
            deck.Enqueue(card32);
            deck.Enqueue(card33);
            deck.Enqueue(card34);
            deck.Enqueue(card35);
            deck.Enqueue(card36);
            deck.Enqueue(card37);
            deck.Enqueue(card38);
            deck.Enqueue(card39);
            deck.Enqueue(card40);
            deck.Enqueue(card41);
            deck.Enqueue(card42);
            deck.Enqueue(card43);
            deck.Enqueue(card44);
            deck.Enqueue(card45);
            deck.Enqueue(card46);
            deck.Enqueue(card47);
            deck.Enqueue(card48);
            deck.Enqueue(card49);
            deck.Enqueue(card50);
            deck.Enqueue(card51);
            deck.Enqueue(card52);
            deck.Enqueue(card53);
            deck.Enqueue(card54);
            deck.Enqueue(card55);
            deck.Enqueue(card56);
            deck.Enqueue(card57);
            deck.Enqueue(card58);
            deck.Enqueue(card59);
            deck.Enqueue(card60);
            deck.Enqueue(card61);
            deck.Enqueue(card62);
            deck.Enqueue(card63);
            deck.Enqueue(card64);
            deck.Enqueue(card65);
            deck.Enqueue(card66);
            deck.Enqueue(card67);
            deck.Enqueue(card68);
            deck.Enqueue(card69);
            deck.Enqueue(card70);
            deck.Enqueue(card71);
            deck.Enqueue(card72);
            deck.Enqueue(card73);
            deck.Enqueue(card74);
            deck.Enqueue(card75);
            deck.Enqueue(card76);
            deck.Enqueue(card77);
            deck.Enqueue(card78);
            deck.Enqueue(card79);
            deck.Enqueue(card80);
            deck.Enqueue(card81);
        }

        // Unfinished
        public Cards[] getCardsOnBoard()
        {
            while (numCardsOnBoard <12)
            {
                cardsOnBoard[numCardsOnBoard] = getNewCard();
                numCardsOnBoard++;
            }
          
            return cardsOnBoard;
        }

        // Unfinished
        public int getUsers()
        {
            return 0;
        }

        // Unfinished
        public int getUserScore(int v)
        {
            return players[v - 1].Score;
        }

        // Unfinished
        public void setUserScore(int player, int score)
        {
            if (score > 0)
            {
                players[player - 1].Score++;
            }
            else
            {
                players[player - 1].Score--;
            }
        }

        // Unfinished
        public List<List<Cards>> getUserSets()
        {
            return null;
        }

        // Unfinished
        public Cards getNewCard()
        {
            Cards newCard = new Cards();
            newCard = deck.Dequeue();
            newCard.Inplay = true;

            return newCard;
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
