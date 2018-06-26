namespace Solutions
{
    using System.Collections.Generic;

    public class SubsetsSol
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var res = new List<IList<int>>();
            this.Helper(nums, res, 0, new HashSet<int>());
            return res;
        }

        private void Helper(int[] nums, IList<IList<int>> res, int index, HashSet<int> chosen)
        {
            if (index < nums.Length)
            {
                res.Add(new List<int>(chosen));
            }

            for (int i = index; i < nums.Length; i++)
            {
                chosen.Add(nums[i]);
                this.Helper(nums, res, index, chosen);
                chosen.Remove(nums[i]);
            }
        }
    }
}