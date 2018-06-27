namespace Solutions
{
    using System.Collections.Generic;

    public class PalindromePartitioning
    {
        public IList<IList<string>> Partition(string s)
        {
            var res = new List<IList<string>>();
            this.Helper(s, res, new List<string>(), 0);
            return res;
        }

        private void Helper(string s, IList<IList<string>> res, List<string> current, int index)
        {
            if (s.Length == index)
            {
                res.Add(new List<string>(current));
                return;
            }

            for (int i = index; i < s.Length; i++)
            {
                var str = s.Substring(index, i - index + 1);
                if (this.isPalindrome(str))
                {
                    current.Add(str);
                    this.Helper(s, res, current, i + 1);
                    current.RemoveAt(current.Count - 1);
                }
            }
        }

        private bool isPalindrome(string p)
        {
            if (string.IsNullOrEmpty(p)) return false;
            int i = 0;
            int j = p.Length - 1;
            while (i < j)
            {
                if (p[i] != p[j]) return false;
                i++;
                j--;
            }

            return true;
        }
    }
}