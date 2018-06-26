namespace Solutions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class RestoreIPAddressesSol
    {
        public IList<string> RestoreIpAddressesRecursion(string s)
        {
            var res = new List<string>();
            HelperRecursion(s, res, string.Empty, 0, 0);
            return res;
        }

        private void HelperRecursion(string s, IList<string> res, string choosen, int index, int count)
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
                HelperRecursion(s, res, choosen + item + (count == 3 ? "" : "."), index + i, count + 1);
            }
        }

        public IList<string> RestoreIpAddressesBackTracking(string s)
        {
            var res = new List<string>();
            HelperBackTracking(s, res, new List<string>(), 0);
            return res;
        }

        private void HelperBackTracking(string s, IList<string> res, List<string> choosen, int index)
        {
            if (choosen.Count > 4)
            {
                return;
            }

            if (choosen.Count == 4 && index == s.Length)
            {
                var builder = new StringBuilder();
                for (int i = 0; i < choosen.Count - 1; i++)
                {
                    int value = -1;
                    var parsed = int.TryParse(choosen[i], out value);
                    if (parsed && value >= 0 && value <= 255)
                    {
                        builder.Append(choosen[i] + ".");
                    }
                    else
                    {
                        return;
                    }
                }
                builder.Append(choosen[choosen.Count - 1]);
                res.Add(builder.ToString());
                return;
            }

            for (int i = 1; i < 4; i++)
            {
                if (i + index > s.Length) break;
                var item = s.Substring(index, i);
                if ((item.StartsWith("0") && item.Length > 1) || (i == 3 && int.Parse(item) >= 256)) continue;
                choosen.Add(item);
                HelperBackTracking(s, res, choosen, index + i);
                choosen.RemoveAt(choosen.Count - 1);
            }
        }
    }
}