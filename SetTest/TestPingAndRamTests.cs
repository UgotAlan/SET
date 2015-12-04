namespace SET.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Unit Tests for both CheckPingTest and CheckRamTest Methods
    /// </summary>
    [TestClass]
    public class TestPingAndRamTests
    {
        /// <summary>
        /// Unit Test for CheckPingTest Method
        /// </summary>
        [TestMethod]
        public void CheckPingTest()
        {
            SET.TestPingAndRam testPing = new TestPingAndRam();

            Assert.IsTrue(testPing.CheckPing(300, "www.google.com"));
            Assert.IsFalse(testPing.CheckPing(-100, "www.google.com"));
            Assert.IsFalse(testPing.CheckPing(300, "a;sldkfj"));
        }

        /// <summary>
        /// Unit Test for CheckRamTest Method
        /// </summary>
        [TestMethod]
        public void CheckRamTest()
        {
            SET.TestPingAndRam testRam = new TestPingAndRam();
            Assert.IsTrue(testRam.CheckRam(4000));
            Assert.IsFalse(testRam.CheckRam(800));
        }
    }
}