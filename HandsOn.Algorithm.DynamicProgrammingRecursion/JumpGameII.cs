using System;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace HandsOn.Algorithms.ArraysAndStrings.DynamicProgramming
{
    public static class JumpGameII
    {
        public static int calculateSteps(int[] nums)
        {
            int[] dp = new int[nums.Length];
            dp[0] = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums[i] + i + 1 && j < nums.Length; j++)
                {
                    if (dp[j] == 0) dp[j] = dp[i] + 1;
                    else dp[j] = Math.Min(dp[i] + 1, dp[j]);
                }
            }
            return dp[dp.Length - 1];
        }
    }
}