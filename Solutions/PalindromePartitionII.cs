using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class PalindromePartitionII
    {
        public int MinCut(string s)
        {
            var pa = new bool[s.Length, s.Length];
            var cuts = new int[s.Length];

            for (int i = s.Length - 1; i >= 0; i--)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (s[i] == s[j] && (j - i <= 1 || pa[i + 1, j - 1]))
                    {
                        pa[i, j] = true;
                    }
                }
            }

            for (int j = 0; j < s.Length; j++)
            {
                // by default we need j cut from s[0] to s[j]
                int cut = j;

                for (int i = 0; i <= j; i++)
                {
                    if (pa[i, j])
                    {
                        // s[i] to s[j] is a palindrome
                        // try to update the cut with cuts[i - 1]
                        cut = Math.Min(cut, i == 0 ? 0 : cuts[i - 1] + 1);
                    }
                }

                cuts[j] = cut;
            }
            return cuts[s.Length - 1];
        }
    }
}
