namespace Solutions
{
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveInvalidParenthesesSol
    {
        public IList<string> RemoveInvalidParentheses(string s)
        {
            if (string.IsNullOrEmpty(s)) return new List<string> { string.Empty };
            var res = new List<string>();
            var visited = new HashSet<string>();
            var queue = new Queue<string>();
            queue.Enqueue(s);
            var found = false;
            while (queue.Any())
            {
                var node = queue.Dequeue();
                if (this.IsValid(node))
                {
                    res.Add(node);
                    found = true;
                }

                if (found) continue;
                for (int i = 0; i < node.Length; i++)
                {
                    if (node[i] != '(' && node[i] != ')') continue;
                    var child = node.Remove(i, 1);
                    if (!visited.Contains(child))
                    {
                        queue.Enqueue(child);
                        visited.Add(child);
                    }
                }
            }

            return res.Count() != 0 ? res : new List<string> { string.Empty };
        }

        private bool IsValid(string chosen)
        {
            var stack = new Stack<char>();
            for (int i = 0; i < chosen.Length; i++)
            {
                if (chosen[i] == '(')
                {
                    stack.Push(chosen[i]);
                }
                else if (chosen[i] == ')')
                {
                    if (!stack.Any()) return false;
                    stack.Pop();
                }
            }

            return !stack.Any();
        }
    }
}