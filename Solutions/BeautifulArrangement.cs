namespace Solutions
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    // 526. Beautiful Arrangement
    public class BeautifulArrangement
    {
        private int count = 0;

        public int CountArrangement(int N)
        {
            var res = new List<List<int>>();
            var currentlist = new List<int>();
            Helper(N, 1, new bool[N + 1], res, currentlist);
            Console.WriteLine("Count: " + res.Count);
            foreach (var re in res)
            {
                Console.WriteLine();
                foreach (var i in re)
                {
                    Console.Write($"{i},");
                }
            }

            return count;
        }

        private void Helper(int n, int current, bool[] visited, List<List<int>> res, List<int> currentList)
        {
            if (current > n)
            {
                count++;
                res.Add(new List<int>(currentList));
             
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                if (!visited[i] && (current % i == 0 || i % current == 0))
                {
                    visited[i] = true;
                    currentList.Add(i);
                    Helper(n, current + 1, visited, res, currentList);
                    currentList.RemoveAt(currentList.Count - 1);
                    visited[i] = false;
                }
            }
        }
    }
}