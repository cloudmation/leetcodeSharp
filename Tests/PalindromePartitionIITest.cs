using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class PalindromePartitionIITest
    {
        [TestMethod]
        public void Test1()
        {
            var sol = new PalindromePartitionII();
            Assert.AreEqual(1, sol.MinCut("aab"));
            Assert.AreEqual(0, sol.MinCut("efeefe"));
        }
    }

}
