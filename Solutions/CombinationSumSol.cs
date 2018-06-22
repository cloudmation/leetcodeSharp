namespace Solutions
{
    using System.Collections.Generic;

    public class CombinationSumSol
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var res = new List<IList<int>>();
            var current = new List<int>();
            this.Helper(candidates, target, res, current, 0, 0);
            return res;
        }

        private void Helper(int[] candidates, int target, IList<IList<int>> res, IList<int> current, int sum, int index)
        {
            if (sum == target)
            {
                res.Add(new List<int>(current));
                return;
            }

            if (sum > target)
            {
                return;
            }

            if (index == candidates.Length)
            {
                return;
            }

            for (int i = index; i < candidates.Length; i++)
            {
                current.Add(candidates[i]);
                sum += candidates[i];
                this.Helper(candidates, target, res, current, sum, i);
                sum -= candidates[i];
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}