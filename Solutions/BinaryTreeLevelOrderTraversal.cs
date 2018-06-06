namespace Solutions
{
    using System.Collections.Generic;

    public class BinaryTreeLevelOrderTraversal
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

        public class TreeNode
        {
            public TreeNode left;

            public TreeNode right;

            public int val;

            public TreeNode(int x)
            {
                this.val = x;
            }
        }
    }
}