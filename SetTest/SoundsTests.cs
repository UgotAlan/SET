namespace SET.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SET;

    /// <summary>
    /// Unit Testing for Sounds.cs Class.
    /// </summary>
    [TestClass]
    public class SoundsTests
    {
        /// <summary>
        /// Unit Test for playMusic Method.
        /// </summary>
        [TestMethod]
        public void PlayMusicTest()
        {
            Sounds sound = new Sounds();
            Assert.IsTrue(sound.PlayMusic(true));
            Assert.IsFalse(sound.PlayMusic(false));
        }

        /// <summary>
        /// Unit Test for playMusicIntro Method.
        /// </summary>
        [TestMethod]
        public void PlayMusicIntroTest()
        {
            Sounds sound = new Sounds();
            Assert.IsTrue(sound.PlayMusicIntro(true));
            Assert.IsFalse(sound.PlayMusicIntro(false));
        }

        /// <summary>
        /// Unit Test for playWrong Method.
        /// </summary>
        [TestMethod]
        public void PlayWrongTest()
        {
            Sounds sound = new Sounds();
            Assert.IsTrue(sound.PlayWrong(true));
            Assert.IsFalse(sound.PlayWrong(false));
        }

        /// <summary>
        /// Unit Test for playRight Method.
        /// </summary>
        [TestMethod]
        public void PlayRightTest()
        {
            Sounds sound = new Sounds();
            Assert.IsTrue(sound.PlayRight(true));
            Assert.IsFalse(sound.PlayRight(false));
        }
    }
}