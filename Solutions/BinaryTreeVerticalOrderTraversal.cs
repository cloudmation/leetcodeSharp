namespace Solutions
{
    using System;
    using System.Collections.Generic;

    public class BinaryTreeVerticalOrderTraversal
    {
        public IList<IList<int>> VerticalOrder(TreeNode root)
        {
            var res = new List<IList<int>>();
            if (root == null) return res;
            var queue = new Queue<Tuple<int, TreeNode>>();
            queue.Enqueue(Tuple.Create(0, root));
            var sorted = new SortedList<int, IList<int>>();
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (sorted.ContainsKey(node.Item1))
                {
                    sorted[node.Item1].Add(node.Item2.val);
                }
                else
                {
                    sorted.Add(node.Item1, new List<int>());
                    sorted[node.Item1].Add(node.Item2.val);
                }

                if (node.Item2.left != null)
                {
                    queue.Enqueue(Tuple.Create(node.Item1 - 1, node.Item2.left));
                }

                if (node.Item2.right != null)
                {
                    queue.Enqueue(Tuple.Create(node.Item1 + 1, node.Item2.right));
                }
            }
            foreach (var list in sorted)
            {
                res.Add(list.Value);
            }
            return res;
        }
    }
}