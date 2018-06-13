namespace Tests
{
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Solutions;

    [TestClass]
    public class RemoveInvalidParenthesesTest
    {
        [TestMethod]
        public void Test1()
        {
            var sol = new RemoveInvalidParenthesesSol();
            var res = sol.RemoveInvalidParentheses("()())()");
            CollectionAssert.AreEquivalent(new List<string> { "()()()", "(())()" }.ToArray(), res.ToArray());
        }
    }
}