namespace Tests
{
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Solutions;

    [TestClass]
    public class RestoreIPAddressesTest
    {
        [TestMethod]
        public void Test1()
        {
            var sol = new RestoreIPAddressesSol();
            var res = sol.RestoreIpAddresses("25525511135");
            CollectionAssert.AreEquivalent(
                new List<string>() { "255.255.11.135", "255.255.111.35" }.ToArray(),
                res.ToArray());
        }
    }
}