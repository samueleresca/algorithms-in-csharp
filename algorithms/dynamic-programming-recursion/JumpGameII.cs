using System;

namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public static class JumpGameII
    {
        public static int calculateSteps(int[] nums)
        {
            int reachable = 0, lastReachable = 0, steps = 0;

            for (var i = 0; i < nums.Length - 1; i++)
            {
                reachable = Math.Max(reachable, i + nums[i]);

                if (i != lastReachable) continue;
                steps++;
                lastReachable = reachable;
                if (reachable >= nums.Length - 1) break;
            }

            return steps;
        }
    }
}