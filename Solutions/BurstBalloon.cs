namespace Solutions
{
    using System;

    public class BurstBalloon
    {
        public int MaxCoins(int[] nums)
        {
            return this.Helper(nums, 0, nums.Length - 1);
        }

        private int Helper(int[] nums, int left, int right)
        {
            if (left > right) return 0;
            var max = 0;
            for (int i = left; i <= right; i++)
            {
                var leftSeg = this.Helper(nums, left, i - 1);
                var rightSeg = this.Helper(nums, i + 1, right);
                var leftValue = left < 1 ? 1 : nums[left - 1];
                var rightValue = right >= nums.Length - 1 ? 1 : nums[right + 1];
                Console.WriteLine("left: " + left + " right:" + right + " i:" + i);
                var current = leftValue * nums[i] * rightValue;
                max = Math.Max(max, leftSeg + current + rightSeg);
            }

            return max;
        }
    }
}