namespace Solutions
{
    using System;

    public class CoinChange2
    {
        public int Change(int amount, int[] coins)
        {
            var dp = new int[amount + 1, coins.Length + 1];
            for (int i = 0; i <= amount; i++)
            {
                dp[i, 0] = 1;
                Console.WriteLine($"dp[{i},{0}]={dp[i, 0]}");
            }

            for (int i = 1; i <= amount; i++)
            {
                for (int j = 1; j <= coins.Length; j++)
                {
                    Console.WriteLine("coins[j - 1]:" + coins[j - 1] + " amount:" + amount + " j:" + j);
                    if (coins[j - 1] > amount)
                    {
                        dp[i, j] = dp[i, j - 1];
                    }
                    else
                    {
                        dp[i, j] = dp[i, j - 1] + dp[amount - coins[j - 1], j - 1];
                    }

                    Console.Write($"dp[{i},{j}]={dp[i, j]}");
                }

                Console.WriteLine();
            }

            return dp[amount, coins.Length];
        }
    }
}