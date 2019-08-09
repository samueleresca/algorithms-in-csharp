using System.Collections.Generic;
using System.Linq;

namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public static class FrequentIntegerArray
    {
        public static IList<int> TopKFrequent(int[] nums, int k)
        {
            var dictionary = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(nums[i]))
                {
                    dictionary[nums[i]] = dictionary[nums[i]] + 1;
                    continue;
                }

                dictionary.Add(nums[i], 1);
            }


            var keyValuePairs = dictionary.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
            return keyValuePairs.Take(k).ToList();
        }
    }
}