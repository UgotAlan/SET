namespace SetTest
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// This class contains all methods used to test the Players.cs file
    /// </summary>
    [TestClass]
    public class PlayersTest
    {
        /// <summary>
        /// This method tests the default constructor for the Players class.
        /// </summary>
        [TestMethod]
        public void TestDefaultConstructor()
        {
            SET.Players players = new SET.Players();
            Assert.IsTrue(players.IsHost);
            Assert.IsFalse(players.Mute);
            Assert.IsTrue(players.NumberOfPlayers == 1);
            Assert.IsTrue(players.Score == 0);
        }

        /// <summary>
        /// This method tests every getter/setter in the Players class
        /// </summary>
        [TestMethod]
        public void TestGettersSetters()
        {
            SET.Players players = new SET.Players();
            players.IsHost = false;
            players.NumberOfPlayers = 5;
            players.Mute = true;
            players.Score = 15;

            SET.Cards cards = new SET.Cards();
            List<SET.Cards> tempList = new List<SET.Cards>();
            tempList.Add(cards);
            tempList.Add(cards);
            tempList.Add(cards);
            players.SetsMade.Add(tempList);
            Assert.IsTrue(players.SetsMade.Contains(tempList));

            players.Keybinds.Add('a', 'b');
            Assert.IsTrue(players.Keybinds['a'] == 'b');
        }
    }
}