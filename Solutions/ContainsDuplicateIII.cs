﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class ContainsDuplicateIII
    {
       public bool ContainsNearbyAlmostDuplicateBruteForce(int[] nums, int k, int t)
        {
            if (k == 0) return false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; (j <= i + k && j < nums.Length); j++)
                {
                    //Console.WriteLine($"i={i} j={j}");
                    var numsDiff = Math.Abs((long)nums[i] - (long)nums[j]);
                    var indexDiff = Math.Abs(i - j);
                    if (numsDiff <= t && indexDiff <= k)
                    {
                        //Console.WriteLine($"numsDiff={numsDiff} indexDiff={indexDiff}");
                        return true;
                    }
                }
            }

            return false;
        }

       
        public bool ContainsNearbyAlmostDuplicateTree(int[] nums, int k, int t)
        {
            if (nums == null || nums.Length < 2 || k < 1 || t < 0) return false;
            SortedSet<long> ss = new SortedSet<long>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > k) ss.Remove(nums[i - k - 1]);

                if (ss.GetViewBetween((long)nums[i] - t, (long)nums[i] + t).Count > 0) return true;
                ss.Add(nums[i]);
            }
            return false;
        }

        public bool ContainsNearbyAlmostDuplicateBucket(int[] nums, int k, int t)
        {
            if (k <= 0 || t < 0) return false;

            var n = nums.Length;
            var dict = new Dictionary<long, long>();
            var bucketSize = t + (long)1;
            for (var i = 0; i < n; i++)
            {
                var bucket = getID(nums[i], bucketSize);

                if (dict.ContainsKey(bucket)) return true;
                if (dict.ContainsKey(bucket - 1) && nums[i] - dict[bucket - 1] <= t) return true;
                if (dict.ContainsKey(bucket + 1) && dict[bucket + 1] - nums[i] <= t) return true;
                if (dict.Count >= k) dict.Remove(getID(nums[i - k], bucketSize));
               
                dict[bucket] = nums[i];
            }

            return false;
        }

        private long getID(long value, long bucketSize)
        {
            return value < 0 ? (value + 1) / bucketSize - 1 : value / bucketSize;
        }
    }
}
