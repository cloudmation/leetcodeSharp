namespace Tests
{
    using System.Collections.Generic;
    using System.Net;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Solutions;

    [TestClass]
    public class CombinationSumTest
    {
        [TestMethod]
        public void Test1()
        {
            var sol = new CombinationSumSol();
            var res = sol.CombinationSum(new[] { 2, 3, 6, 7 }, 7);
            var expected = new List<IList<int>> { new List<int>() { 2, 2, 3 }, new List<int>() { 7 }};
            Utlilitiy.AssertAreEqual(expected, res);
        }
    }
}