namespace Solutions
{
    using System.Collections.Generic;
    using System.Linq;

    public partial class BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null) return new List<IList<int>>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var results = new List<IList<int>>();
            while (queue.Count > 0)
            {
                //Console.WriteLine($"new list");
                var currentList = new List<int>();
                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    //Console.WriteLine($"Dequeue:{node.val}");
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                        //Console.WriteLine($"Enqueue:{node.left.val}");
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                        //Console.WriteLine($"Enqueue:{node.right.val}");
                    }
                    currentList.Add(node.val);
                }
                //Console.WriteLine($"add to list");
                results.Add(currentList);
            }
            return results;
        }

        public IList<IList<int>> LevelOrderRecursive(TreeNode root)
        {
            if (root == null) return new List<IList<int>>();
            var results = new List<IList<int>>();
            Helper(results, root, 0);
            return results;
        }

        private void Helper(IList<IList<int>> results, TreeNode root, int level)
        {
            if (root == null) return;

            if (level >= results.Count)
            {
                results.Add(new List<int>());
            }

            results[level].Add(root.val);

            if (root.left != null)
            {
                Helper(results, root.left, level + 1);
            }

            if (root.right != null)
            {
                Helper(results, root.right, level + 1);
            }
        }
    }
}