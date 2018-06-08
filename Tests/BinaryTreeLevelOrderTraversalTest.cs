namespace Tests
{
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Solutions;

    [TestClass]
    public class BinaryTreeLevelOrderTraversalTest
    {
        [TestMethod]
        public void TestIterative()
        {
            var sol = new BinaryTreeLevelOrderTraversal();
            var root = new TreeNode(3)
                                {
                                    left = new TreeNode(9),
                                    right = new TreeNode(20)
                                                {
                                                    left = new TreeNode(15),
                                                    right = new TreeNode(7)
                                                }
                                };
            var ret = sol.LevelOrder(root);
            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int>() { 3 });
            expected.Add(new List<int>() { 9, 20 });
            expected.Add(new List<int>() { 15, 7 });
            Utlilitiy.AssertAreEqual(expected, ret);
        }
    }
}