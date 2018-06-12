namespace Tests
{
    using System;
    using System.Runtime.InteropServices;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Solutions;

    [TestClass]
    public class LoudAndRichSolTest
    {
        [TestMethod]
        public void Test1()
        {
            var sol = new LoudAndRichSol();
            var richer = new int[][]
                             {
                                 new[] { 1, 0 }, new[] { 2, 1 }, new[] { 3, 1 }, new[] { 3, 7 }, new[] { 4, 3 },
                                 new[] { 5, 3 }, new[] { 6, 3 }
                             };
            var quiet = new[] { 3, 2, 5, 4, 6, 1, 7, 0 };
            var res = sol.LoudAndRich(richer, quiet);
            Console.WriteLine(res.Print());
            CollectionAssert.AreEqual(new[] { 5, 5, 2, 5, 4, 5, 6, 7 }, res);
        }
    }
}