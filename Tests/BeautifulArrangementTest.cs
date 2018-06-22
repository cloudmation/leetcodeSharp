namespace Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Solutions;

    [TestClass]
    public class BeautifulArrangementTest
    {
        [TestMethod]
        public void Test1()
        {
            var sol = new BeautifulArrangement();
            var res = sol.CountArrangement(3);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void Test2()
        {
            var sol = new BeautifulArrangement();
            var res = sol.CountArrangement(4);
            Assert.AreEqual(8, res);
        }
    }
}