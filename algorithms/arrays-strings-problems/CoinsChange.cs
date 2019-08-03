using System;
using System.Linq;
using System.Net.WebSockets;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class CoinsChange
    {

        public int GetAmountOfCoins(int[] coins, int amount)
        {
            int max = amount + 1;
            int[] dp = new int[amount + 1];
            Array.Fill(dp, max);
            dp[0] = 0;
            for (int i = 1; i <= amount; i++)
            {
                for (int j = 0; j < coins.Length; j++)
                {
                    if (coins[j] <= i)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
                    }
                }
            }
            return dp[amount] > amount ? -1 : dp[amount];
        }

        private int coinChange(int idxCoin, int[] coins, int amount)
        {
            if (amount == 0)
                return 0;
            if (idxCoin >= coins.Length || amount <= 0) return -1;

            var maxVal = amount / coins[idxCoin];
            var minCost = int.MaxValue;
            for (int x = 0; x <= maxVal; x++)
            {
                if (amount < x * coins[idxCoin]) continue;
                int res = coinChange(idxCoin + 1, coins, amount - x * coins[idxCoin]);
                if (res != -1)
                    minCost = Math.Min(minCost, res + x);
            }
            return (minCost == int.MaxValue) ? -1 : minCost;
        }
    }
}