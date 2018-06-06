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
            BinaryTreeLevelOrderTraversal.TreeNode root = new BinaryTreeLevelOrderTraversal.TreeNode(3);
            root.left = new BinaryTreeLevelOrderTraversal.TreeNode(9);
            root.right =
                new BinaryTreeLevelOrderTraversal.TreeNode(20)
                    {
                        left = new BinaryTreeLevelOrderTraversal.TreeNode(15)
                    };
            root.right.left = new BinaryTreeLevelOrderTraversal.TreeNode(7);
            var ret = sol.LevelOrder(root);
            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int>() { 3 });
            expected.Add(new List<int>() { 9, 20 });
            expected.Add(new List<int>() { 15, 7 });
            CollectionAssert.AreEqual(expected.ToArray(), ret.ToArray());
        }
    }
}