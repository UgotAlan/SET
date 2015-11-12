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
        /// This method tests the default constructor for the Cards class.
        /// </summary>
        [TestMethod]
        public void TestDefaultConstructor()
        {
            SET.Cards cards = new SET.Cards();
            Assert.IsFalse(cards.Inplay);
            Assert.IsFalse(cards.BeenPlayed);
            Assert.IsTrue(cards.Image == string.Empty);
            Assert.IsTrue(cards.Color == string.Empty);
            Assert.IsTrue(cards.Shade == string.Empty);
            Assert.IsTrue(cards.Shape == string.Empty);
            Assert.IsTrue(cards.Number == 0);
        }

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
            Assert.IsFalse(cards.Inplay);
            Assert.IsTrue(cards.BeenPlayed);
        }
    }
}
