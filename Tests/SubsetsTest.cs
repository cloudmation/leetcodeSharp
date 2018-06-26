namespace Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Solutions;

    [TestClass]
    public class SubsetsTest
    {
        [TestMethod]
        public void Test1()
        {
            var sol = new SubsetsSol();
            var res = sol.Subsets(new[] { 1, 2, 3 });

        }
    }
}