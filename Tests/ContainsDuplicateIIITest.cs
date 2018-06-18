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
            Assert.AreEqual(true, sol.ContainsNearbyAlmostDuplicateBruteForce(new[] { 7, 1, 3 }, 2, 3));
            Assert.AreEqual(true, sol.ContainsNearbyAlmostDuplicateBruteForce(new[] { 1, 0, 1, 1 }, 1, 2));
            Assert.AreEqual(false, sol.ContainsNearbyAlmostDuplicateBruteForce(new[] { 1, 5, 9, 1, 5, 9 }, 2, 3));
        }

        [TestMethod]
        public void Test1Tree()
        {
            var sol = new ContainsDuplicateIII();
            Assert.AreEqual(true, sol.ContainsNearbyAlmostDuplicateTree(new[] { 7, 1, 3 }, 2, 3));
            Assert.AreEqual(true, sol.ContainsNearbyAlmostDuplicateTree(new[] { 1, 0, 1, 1 }, 1, 2));
            Assert.AreEqual(false, sol.ContainsNearbyAlmostDuplicateTree(new[] { 1, 5, 9, 1, 5, 9 }, 2, 3));
        }

        [TestMethod]
        public void Test1Bucket()
        {
            var sol = new ContainsDuplicateIII();
            Assert.AreEqual(false, sol.ContainsNearbyAlmostDuplicateBucket(new[] { 1, 5, 9, 1, 5, 9 }, 2, 3));
            Assert.AreEqual(true, sol.ContainsNearbyAlmostDuplicateBucket(new[] { 7, 1, 3 }, 2, 3));
            Assert.AreEqual(true, sol.ContainsNearbyAlmostDuplicateBucket(new[] { 1, 0, 1, 1 }, 1, 2));
        }
    }
}