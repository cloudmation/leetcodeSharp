namespace Solutions
{
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveInvalidParenthesesSol
    {
        private int minSteps = int.MaxValue;

        private int totalLength = 0;

        public IList<string> RemoveInvalidParentheses(string s)
        {
            var res = new List<string>();
            if (s == null) return res;
            this.totalLength = s.Length;
            this.Helper(s, res);
            for (int i = res.Count - 1; i >= 0; i--)
            {
                if (s.Length - res[i].Length > this.minSteps)
                {
                    res.RemoveAt(i);
                }
            }
            return res;
        }

        private void Helper(string chosen, IList<string> res)
        {
            if (this.minSteps >= (this.totalLength - chosen.Length) && !res.Contains(chosen) && this.IsValid(chosen))
            {
                this.minSteps = this.totalLength - chosen.Length;
                res.Add(chosen);
                return;
            }

            for (int i = 0; i < chosen.Length; i++)
            {
                this.Helper(chosen.Remove(i, 1), res);
            }
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
                    if(!stack.Any()) return false;
                    stack.Pop();
                }
            }

            return !stack.Any();
        }
    }
}