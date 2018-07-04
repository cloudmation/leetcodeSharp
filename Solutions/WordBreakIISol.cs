using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public class WordBreakIISol
    {
        private readonly IDictionary<int, IList<string>> map = new Dictionary<int, IList<string>>();

        public IList<string> WordBreak(string s, IList<string> wordDict)
        {

            return Helper(new HashSet<string>(wordDict), s, 0);

        }

        private IList<string> Helper(HashSet<string> wordDict, string s, int index)
        {
            if (map.ContainsKey(index))
            {
                return map[index];
            }

            IList<string> res = new List<string>();
            if (index == s.Length)
            {
                res.Add("");
            }

            for (int i = 1; i <= s.Length - index; i++)
            {
                var str = s.Substring(index, i);
                if (wordDict.Contains(str))
                {
                    var list = Helper(wordDict, s, index + i);
                    foreach (string l in list)
                    {
                        res.Add(str + (l.Equals("") ? "" : " ") + l);
                    }
                }
            }

            map[index] = res;
            return res;
        }
    }
}