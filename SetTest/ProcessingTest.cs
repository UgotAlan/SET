namespace SetTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SET;

    /// <summary>
    /// This class contains all methods used to test the ProcessingTest.cs file
    /// </summary>
    [TestClass]
    public class ProcessingTest
    {
        [TestMethod]

        /// <summary>
        /// Unit Test for confirmSet method. It first checks a set of 3 cards where 
        /// all 3 colors and numbers are different and all 3 shades and shape are the same
        /// making an actual set. The second part of the test checks a selection of 3 cards
        /// where all everything is the same as before with the exception that two of the card
        /// numbers are the same and one is not that should return false for not being a set.
        /// </summary>
        public void ConfirmSetTest()
        {
            SET.Processing isSet = new Processing();
            List<Cards> cardList = new List<Cards>();

            SET.Cards card1 = new Cards();
            SET.Cards card2 = new Cards();
            SET.Cards card3 = new Cards();

            card1.Color = "red";
            card1.Number = 1;
            card1.Shade = "solid";
            card1.Shape = "oval";
            card2.Color = "green";
            card2.Number = 2;
            card2.Shade = "solid";
            card2.Shape = "oval";
            card3.Color = "blue";
            card3.Number = 3;
            card3.Shade = "solid";
            card3.Shape = "oval";

            cardList.Insert(0, card1);
            cardList.Insert(1, card2);
            cardList.Insert(2, card3);

            Assert.IsTrue(isSet.ConfirmSet(cardList));

            card1.Color = "red";
            card1.Number = 1;
            card1.Shade = "solid";
            card1.Shape = "oval";
            card2.Color = "green";
            card2.Number = 2;
            card2.Shade = "solid";
            card2.Shape = "oval";
            card3.Color = "blue";
            card3.Number = 2;
            card3.Shade = "solid";
            card3.Shape = "oval";

            cardList.Clear();
            cardList.Insert(0, card1);
            cardList.Insert(1, card2);
            cardList.Insert(2, card3);

            Assert.IsFalse(isSet.ConfirmSet(cardList));
        }

        /// <summary>
        /// Unit Test for CheckSet method. Checks all possible combinations of 3 cards
        /// out of twelve pre-assigned cards representing the game board. First test is
        /// with a list of twelve cards that have no possible "SET" combinations. Second
        /// test is with a list of twelve cards with a possible "SET" combination.
        /// </summary>
        [TestMethod]
        public void CheckSetTest()
        {
            Processing setMethod = new SET.Processing();
            Cards card1 = new Cards();
            Cards card2 = new Cards();
            Cards card3 = new Cards();
            Cards card4 = new Cards();
            Cards card5 = new Cards();
            Cards card6 = new Cards();
            Cards card7 = new Cards();
            Cards card8 = new Cards();
            Cards card9 = new Cards();
            Cards card10 = new Cards();
            Cards card11 = new Cards();
            Cards card12 = new Cards();

            List<Cards> listTwelve = new List<Cards>();

            card1.Color = "blue";
            card1.Number = 1;
            card1.Shade = "outline";
            card1.Shape = "rectangle";
            card2.Color = "blue";
            card2.Number = 2;
            card2.Shade = "outline";
            card2.Shape = "rectangle";
            card3.Color = "blue";
            card3.Number = 1;
            card3.Shade = "solid";
            card3.Shape = "diamond";
            card4.Color = "red";
            card4.Number = 1;
            card4.Shade = "pattern";
            card4.Shape = "oval";
            card5.Color = "red";
            card5.Number = 2;
            card5.Shade = "solid";
            card5.Shape = "rectangle";
            card6.Color = "green";
            card6.Number = 3;
            card6.Shade = "outline";
            card6.Shape = "rectangle";
            card7.Color = "blue";
            card7.Number = 3;
            card7.Shade = "pattern";
            card7.Shape = "rectangle";
            card8.Color = "green";
            card8.Number = 3;
            card8.Shade = "outline";
            card8.Shape = "diamond";
            card9.Color = "red";
            card9.Number = 2;
            card9.Shade = "outline";
            card9.Shape = "diamond";
            card10.Color = "red";
            card10.Number = 1;
            card10.Shade = "solid";
            card10.Shape = "oval";
            card11.Color = "blue";
            card11.Number = 1;
            card11.Shade = "solid";
            card11.Shape = "oval";
            card12.Color = "green";
            card12.Number = 3;
            card12.Shade = "solid";
            card12.Shape = "rectangle";

            listTwelve.Insert(0, card1);
            listTwelve.Insert(1, card2);
            listTwelve.Insert(2, card3);
            listTwelve.Insert(3, card4);
            listTwelve.Insert(4, card5);
            listTwelve.Insert(5, card6);
            listTwelve.Insert(6, card7);
            listTwelve.Insert(7, card8);
            listTwelve.Insert(8, card9);
            listTwelve.Insert(9, card10);
            listTwelve.Insert(10, card11);
            listTwelve.Insert(11, card12);

            Assert.IsFalse(setMethod.CheckSet(listTwelve));

            card1.Color = "blue";
            card1.Number = 1;
            card1.Shade = "outline";
            card1.Shape = "rectangle";
            card2.Color = "blue";
            card2.Number = 2;
            card2.Shade = "outline";
            card2.Shape = "rectangle";
            card3.Color = "blue";
            card3.Number = 1;
            card3.Shade = "solid";
            card3.Shape = "diamond";
            card4.Color = "red";
            card4.Number = 1;
            card4.Shade = "pattern";
            card4.Shape = "oval";
            card5.Color = "red";
            card5.Number = 2;
            card5.Shade = "solid";
            card5.Shape = "rectangle";
            card6.Color = "green";
            card6.Number = 3;
            card6.Shade = "pattern";
            card6.Shape = "rectangle";
            card7.Color = "blue";
            card7.Number = 3;
            card7.Shade = "pattern";
            card7.Shape = "rectangle";
            card8.Color = "green";
            card8.Number = 1;
            card8.Shade = "solid";
            card8.Shape = "diamond";
            card9.Color = "red";
            card9.Number = 3;
            card9.Shade = "outline";
            card9.Shape = "oval";
            card10.Color = "red";
            card10.Number = 1;
            card10.Shade = "solid";
            card10.Shape = "oval";
            card11.Color = "blue";
            card11.Number = 1;
            card11.Shade = "solid";
            card11.Shape = "oval";
            card12.Color = "green";
            card12.Number = 3;
            card12.Shade = "solid";
            card12.Shape = "rectangle";

            listTwelve.Clear();
            listTwelve.Insert(0, card1);
            listTwelve.Insert(1, card2);
            listTwelve.Insert(2, card3);
            listTwelve.Insert(3, card4);
            listTwelve.Insert(4, card5);
            listTwelve.Insert(5, card6);
            listTwelve.Insert(6, card7);
            listTwelve.Insert(7, card8);
            listTwelve.Insert(8, card9);
            listTwelve.Insert(9, card10);
            listTwelve.Insert(10, card11);
            listTwelve.Insert(11, card12);

            Assert.IsTrue(setMethod.CheckSet(listTwelve));
        }
    }
}