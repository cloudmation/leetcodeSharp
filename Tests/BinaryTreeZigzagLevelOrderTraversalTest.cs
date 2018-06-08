namespace Tests
{
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Solutions;

    [TestClass]
    public class BinaryTreeZigzagLevelOrderTraversalTest
    {
        [TestMethod]
        public void Test1()
        {
            var sol = new BinaryTreeZigzagLevelOrderTraversal();
            var root = new TreeNode(3)
                           {
                               left = new TreeNode(9)
                                          {
                                              left =
                                                  new TreeNode(4)
                                                      {
                                                          left = new TreeNode(8),
                                                          right = new TreeNode(9)
                                                      },
                                              right = new TreeNode(5)
                                                          {
                                                              left =
                                                                  new TreeNode(7),
                                                              right = new TreeNode(
                                                                  12)
                                                          }
                                          },
                               right = new TreeNode(20)
                                           {
                                               left =
                                                   new TreeNode(15)
                                                       {
                                                           left =
                                                               new TreeNode(45),
                                                           right = new TreeNode(
                                                               23)
                                                       },
                                               right = new TreeNode(7)
                                                           {
                                                               left = new TreeNode(
                                                                   48),
                                                               right =
                                                                   new TreeNode(50)
                                                           }
                                           }
                           };
            var ret = sol.ZigzagLevelOrder(root);
            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int>() { 3 });
            expected.Add(new List<int>() { 20, 9 });
            expected.Add(new List<int>() { 4, 5, 15, 7 });
            expected.Add(new List<int>() { 50, 48, 23, 45, 12, 7, 9, 8 });
            Utlilitiy.AssertAreEqual(expected, ret);
        }
    }
}