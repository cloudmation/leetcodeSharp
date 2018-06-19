namespace Tests
{
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Solutions;

    [TestClass]
    public class CombinationsTest
    {
        [TestMethod]
        public void Test1()
        {
            var sol = new CombinationsSol();
            var res = sol.Combine(4, 2);
            Utlilitiy.AssertAreEqual(
                new List<IList<int>>()
                    {
                        new List<int>() { 1, 2 },
                        new List<int> { 1, 3 },
                        new List<int> { 1, 4 },
                        new List<int> { 2, 3 },
                        new List<int> { 2, 4 },
                        new List<int> { 3, 4 }
                    },
                res);
        }
    }
}