namespace Solutions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class RestoreIPAddressesSol
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            var res = new List<string>();
            Helper(s, res, string.Empty, 0, 0);
            return res;
        }

        private void Helper(string s, IList<string> res, string choosen, int index, int count)
        {
            if (count > 4)
            {
                return;
            }
            if (count == 4 && index == s.Length)
            {
                res.Add(choosen);
                return;
            }

            for (int i = 1; i < 4; i++)
            {
                if (i + index > s.Length) break;
                var item = s.Substring(index, i);
                if ((item.StartsWith("0") && item.Length > 1) || (i == 3 && int.Parse(item) >= 256)) continue;
                Helper(s, res, choosen + item + (count == 3 ? "" : "."), index + i, count + 1);
            }
        }
    }
}