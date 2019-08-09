using System.Collections.Generic;
using System.Linq;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class GroupAnagrams
    {
        public IList<IList<string>> Group(string[] strs)
        {
            var indexGrouped = new Dictionary<int, List<string>>();
            IList<IList<string>> result = new List<IList<string>>();
            foreach (var str in strs)
            {
                var charCount = str.ToCharArray().Sum(x => (int)x);
                if (indexGrouped.ContainsKey(charCount))
                {
                    indexGrouped[charCount].Add(str);
                    indexGrouped[charCount].Sort();
                    continue;
                }

                var newList = new List<string> { str };
                indexGrouped.Add(charCount, newList);
            }


            foreach (var key in indexGrouped) result.Insert(0, indexGrouped[key.Key]);

            return result;
        }
    }
}