namespace Solutions
{
    using System;
    using System.Collections.Generic;

    public class LoudAndRichSol
    {
        public int[] LoudAndRich(int[][] richer, int[] quiet)
        {
            var richChain = new Dictionary<int, List<int>>();
            for (int i = 0; i < quiet.Length; i++)
            {
                richChain.Add(i, new List<int>());
            }

            foreach (var pair in richer)
            {
                richChain[pair[1]].Add(pair[0]);
            }

            foreach (var key in richChain.Keys)
            {
                Console.Write($"[{key}] -> ");
                foreach (var l in richChain[key])
                {
                    Console.Write($"{l},");
                }

                Console.WriteLine();
            }

            var res = new int[quiet.Length];
            for (int i = 0; i < quiet.Length; i++)
            {
                res[i] = -1;
            }

            for (int i = 0; i < quiet.Length; i++)
            {
                this.Dfs(res, richChain, quiet, i);
            }

            return res;
        }

        private int Dfs(int[] res, Dictionary<int, List<int>> richChain, int[] quiet, int index)
        {
            if (res[index] == -1)
            {
                res[index] = index;
                foreach (var node in richChain[index])
                {
                    var child = this.Dfs(res, richChain, quiet, node);
                    if (quiet[child] <= quiet[res[index]])
                    {
                        res[index] = child;
                    }
                }
            }

            return res[index];
        }
    }
}