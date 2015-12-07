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
    }
}