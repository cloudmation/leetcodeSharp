namespace Tests
{
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Solutions;

    [TestClass]
    public class PalindromePartitioningTest
    {
        [TestMethod]
        public void Test1()
        {
            var sol = new PalindromePartitioning();
            var res = sol.Partition("abba");
            var expected =
                new List<IList<string>>() { new List<string>() { "a", "b", "b", "a" }, new List<string>(){"a", "bb", "a"}, new List<string>(){"abba"} };
            Utlilitiy.AssertAreEqual(expected, res);
        }
    }
}