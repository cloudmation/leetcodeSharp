namespace Solutions
{
    using System.Collections.Generic;

    public class CombinationsSol
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            var ret = new List<IList<int>>();
            if (n < k) return ret;
            this.Helper(n, k, 1, ret, new List<int>());
            return ret;
        }

        private void Helper(int n, int k, int index, IList<IList<int>> ret, IList<int> comb)
        {
            if (comb.Count == k)
            {
                ret.Add(new List<int>(comb));
                return;
            }

            for (int i = index; i <= n; i++)
            {
                comb.Add(i);
                this.Helper(n, k, i + 1, ret, comb);
                comb.RemoveAt(comb.Count - 1);
            }
        }
    }
}