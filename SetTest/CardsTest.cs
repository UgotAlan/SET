namespace SetTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    class CardsTest
    {
        [TestClass]
        public class CardsTests
        {
            [TestMethod]
            public void TestGettersSetters()
            {
                SET.Cards cards = new SET.Cards();
                cards.image = "Test/Here";
                cards.color = "blue";
                cards.shade = "hollow";
                cards.shape = "diamond";
                cards.number = 2;
                cards.inplay = false;
                cards.beenPlayed = true;
                Assert.IsTrue(cards.image == "Test/Here");
                Assert.IsTrue(cards.color == "blue");
                Assert.IsTrue(cards.shade == "hollow");
                Assert.IsTrue(cards.shape == "diamond");
                Assert.IsTrue(cards.number == 2);
                Assert.IsTrue(cards.inplay == false);
                Assert.IsTrue(cards.beenPlayed == true);
            }
        }
    }
}
