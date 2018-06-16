namespace Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Solutions;

    [TestClass]
    public class ContainsDuplicateIIITest
    {
        [TestMethod]
        public void Test1BruteForce()
        {
            var sol = new ContainsDuplicateIII();
            var res = sol.ContainsNearbyAlmostDuplicateBruteForce(new[] { 7, 1, 3 }, 2, 3);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void Test1Tree()
        {
            var sol = new ContainsDuplicateIII();
            var res = sol.ContainsNearbyAlmostDuplicateTree(new[] { 7, 1, 3 }, 2, 3);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void Test1Bucket()
        {
            var sol = new ContainsDuplicateIII();
            var res = sol.ContainsNearbyAlmostDuplicateBucket(new[] { 7, 1, 3 }, 2, 3);
            Assert.AreEqual(true, res);
        }
    }
}