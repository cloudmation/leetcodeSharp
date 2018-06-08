namespace Solutions
{
    using System;
    using System.Collections.Generic;

    public class BinaryTreeZigzagLevelOrderTraversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var res = new List<IList<int>>();
            if (root == null) return res;

            var queue = new Queue<Tuple<TreeNode, int>>();
            queue.Enqueue(Tuple.Create(root, 0));
            while (queue.Count > 0)
            {
                var tuple = queue.Dequeue();
                var node = tuple.Item1;
                var currentLevel = tuple.Item2;

                // Console.WriteLine($"level:{currentLevel}");
                if (res.Count <= currentLevel)
                {
                    res.Add(new List<int>());
                }

                if (currentLevel % 2 == 0)
                {
                    res[currentLevel].Add(node.val);
                }
                else
                {
                    res[currentLevel].Insert(0, node.val);
                }

                if (node.left != null)
                {
                    queue.Enqueue(Tuple.Create(node.left, currentLevel + 1));
                }

                if (node.right != null)
                {
                    queue.Enqueue(Tuple.Create(node.right, currentLevel + 1));
                }
            }

            return res;
        }
    }
}