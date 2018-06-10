namespace Tests
{
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Solutions;

    [TestClass]
    public class WordLadder2Test
    {
        [TestMethod]
        public void Test1()
        {
            var ladder = new WordLadder2();
            var res = ladder.FindLadders("hit", "cog", new List<string>() { "hot", "dot", "dog", "lot", "log", "cog" });
            IList<IList<string>> expected = new List<IList<string>>();
            expected.Add(new List<string>() { "hit", "hot", "dot", "dog", "cog" });
            expected.Add(new List<string>() { "hit", "hot", "lot", "log", "cog" });
            Utlilitiy.AssertAreEqual(expected, res);
        }

        [TestMethod]
        public void Test2()
        {
            var ladder = new WordLadder2();
            var res = ladder.FindLadders(
                "hot",
                "dog",
                new List<string>() { "hot", "cog", "dog", "tot", "hog", "hop", "pot", "dot" });
            IList<IList<string>> expected = new List<IList<string>>();
            expected.Add(new List<string>() { "hot", "hog", "dog" });
            expected.Add(new List<string>() { "hot", "dot", "dog" });
            Utlilitiy.AssertAreEqual(expected, res);
        }

        [TestMethod]
        public void Test3()
        {
            var ladder = new WordLadder2();
            var res = ladder.FindLadders(
                "lost",
                "miss",
                new List<string>() { "most", "mist", "miss", "lost", "fist", "fish" });
            IList<IList<string>> expected = new List<IList<string>>();
            expected.Add(new List<string>() { "lost", "most", "mist", "miss"});
            Utlilitiy.AssertAreEqual(expected, res);
        }
    }
}