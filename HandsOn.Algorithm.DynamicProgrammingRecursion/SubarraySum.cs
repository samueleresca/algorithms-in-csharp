using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public class SubarraySum
    {

        public int subarraySum(int[] nums, int k)
        {
            int count = 0, sum = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();

            map.Add(0, 1);

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (map.ContainsKey(sum - k))
                    count += map[sum - k];

                if (map.ContainsKey(sum))
                {
                    map[sum] = map.GetValueOrDefault(sum, 0) + 1;
                }
                else map.Add(sum, map.GetValueOrDefault(sum, 0) + 1);

            }
            return count;
        }
    }
}