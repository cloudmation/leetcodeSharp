namespace Tests
{
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Solutions;

    [TestClass]
    public class LetterCasePermutationSolTest
    {
        [TestMethod]
        public void Test1()
        {
            var sol = new LetterCasePermutationSol();
            var res = sol.LetterCasePermutation("a1b2");
            var expected = new[] { "a1b2", "a1B2", "A1b2", "A1B2" };
            CollectionAssert.AreEquivalent(expected, res.ToArray());
        }
    }
}