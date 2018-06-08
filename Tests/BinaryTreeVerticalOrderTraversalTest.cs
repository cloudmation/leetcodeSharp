namespace Tests
{
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Solutions;

    [TestClass]
    public class BinaryTreeVerticalOrderTraversalTest
    {
        [TestMethod]
        public void Test1()
        {
            var sol = new BinaryTreeVerticalOrderTraversal();
            var root = new TreeNode(3)
                           {
                               left = new TreeNode(9),
                               right = new TreeNode(20)
                                           {
                                               left = new TreeNode(15),
                                               right = new TreeNode(7)
                                           }
                           };
            var ret = sol.VerticalOrder(root);
            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int>() { 9 });
            expected.Add(new List<int>() { 3, 15 });
            expected.Add(new List<int>() { 20 });
            expected.Add(new List<int>() { 7 });
            Utlilitiy.AssertAreEqual(expected, ret);
        }
    }
}