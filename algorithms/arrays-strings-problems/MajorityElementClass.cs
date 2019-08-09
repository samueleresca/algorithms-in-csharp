using System.Collections.Generic;
using System.Linq;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public static class MajorityElementClass
    {
        public static IList<int> GetMajorityElements(int[] nums)
        {
            var hashTable = new Dictionary<int, int>();

            foreach (var t in nums)
            {
                if (hashTable.ContainsKey(t))
                {
                    hashTable[t] = hashTable[t] + 1;
                    continue;
                }

                hashTable.Add(t, 1);
            }


            var validNumbers = (double)nums.Length / 3;
            return hashTable.Where(x => x.Value > validNumbers).Select(x => x.Key).ToList();
        }
    }
}