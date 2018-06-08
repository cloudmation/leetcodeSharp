namespace Solutions
{
    using System.Collections.Generic;

    public class BinaryTreeVerticalOrderTraversal
    {
        public IList<IList<int>> VerticalOrder(TreeNode root)
        {
            var res = new List<IList<int>>();
            var map = new Dictionary<int, IList<int>>();
            var queue = new Queue<KeyValuePair<int, TreeNode>>();
            queue.Enqueue(new KeyValuePair<int, TreeNode>(0, root));
            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                map[item.Key].Add(item.Value.val);
                if (item.Value.left != null)
                {
                    queue.Enqueue(new KeyValuePair<int, TreeNode>(item.Key - 1, item.Value.left));
                }

                if (item.Value.right != null)
                {
                    queue.Enqueue(new KeyValuePair<int, TreeNode>(item.Key - 1, item.Value.right));
                }
            }

            foreach (var m in map)
            {
                res.Add(m.Value);
            }

            return res;
        }
    }
}