namespace SetTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// This class contains all methods used to test the Cards.cs file
    /// </summary>
    [TestClass]
    public class CardsTests
    {
        /// <summary>
        /// This method tests every getter/setter in the Cards class
        /// </summary>
        [TestMethod]
        public void TestGettersSetters()
        {
            SET.Cards cards = new SET.Cards();
            cards.Image = "Test/Here";
            cards.Color = "blue";
            cards.Shade = "hollow";
            cards.Shape = "diamond";
            cards.Number = 2;
            cards.Inplay = false;
            cards.BeenPlayed = true;
            Assert.IsTrue(cards.Image == "Test/Here");
            Assert.IsTrue(cards.Color == "blue");
            Assert.IsTrue(cards.Shade == "hollow");
            Assert.IsTrue(cards.Shape == "diamond");
            Assert.IsTrue(cards.Number == 2);
            Assert.IsTrue(cards.Inplay == false);
            Assert.IsTrue(cards.BeenPlayed == true);
        }
    }
}
