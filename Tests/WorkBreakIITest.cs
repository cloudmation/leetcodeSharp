using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;

namespace Tests
{
    [TestClass]
    public class WorkBreakIITest
    {
        [TestMethod]
        public void Test1()
        {
            var sol = new WordBreakIISol(); 
            var res = sol.WordBreak("catsanddog", new List<string>() { "cat", "cats", "and", "sand", "dog" });
            CollectionAssert.AreEquivalent(new [] {"cat sand dog", "cats and dog"}, res.ToArray());
        }

        [TestMethod]
        public void Test2()
        {
            var sol = new WordBreakIISol();
            var res = sol.WordBreak("pineapplepenapple"
                , new List<string>() { "apple", "pen", "applepen", "pine", "pineapple" });
            CollectionAssert.AreEquivalent(new[] {"pine apple pen apple",
                "pineapple pen apple",
                "pine applepen apple"}, res.ToArray());
        }

        [TestMethod]
        public void Test3()
        {
            var sol = new WordBreakIISol();
            var res = sol.WordBreak("baaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
               , new List<string>() { "a", "aa", "aaa", "aaaa", "aaaaa", "aaaaaa", "aaaaaaa", "aaaaaaaa", "aaaaaaaaa", "aaaaaaaaaa" });
            CollectionAssert.AreEquivalent(new string[] {}, res.ToArray());
        }
    }
}
