using System.Collections.Generic;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    internal class Solution
    {
        // Complete the sockMerchant function below.
        private static int sockMerchant(int n, int[] ar)
        {
            if (n == 0) return 0;

            var groupedCount = new Dictionary<int, int>();
            var pairsCount = 0;

            for (var i = 0; i < n; i++)
            {
                var currentElement = ar[i];

                if (!groupedCount.TryGetValue(currentElement, out var count))
                {
                    groupedCount.Add(currentElement, 1);
                    continue;
                }

                pairsCount++;
                groupedCount.Remove(currentElement);
            }

            return pairsCount;
        }
    }
}