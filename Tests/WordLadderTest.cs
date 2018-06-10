namespace Tests
{
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Solutions;

    [TestClass]
    public class WordLadderTest
    {
        [TestMethod]
        public void Test1()
        {
            var ladder = new WordLadder();
            var res = ladder.LadderLength("hit", "cog", new List<string>() { "hot", "dot", "dog", "lot", "log", "cog" });
            Assert.AreEqual(5, res);
        }

        [TestMethod]
        public void Test2()
        {
            var ladder = new WordLadder();
            var res = ladder.LadderLength("a", "c", new List<string>() { "a", "b", "c" });
            Assert.AreEqual(2, res);
        }
    }
}