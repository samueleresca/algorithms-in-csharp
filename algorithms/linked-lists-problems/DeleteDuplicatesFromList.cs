using System;
using System.Collections.Generic;
using Xunit;

namespace HandsOn.Algorithms.LinkedLists
{
    public static class DeleteDuplicatesFromList
    {
        public static List<int> DeleteDuplicates(List<int> nodeList)
        {
            HashSet<int> set = new HashSet<int>();

            for (var index = 0; index < nodeList.Count; index++)
            {
                var node = nodeList[index];

                if (set.Contains(node))
                {
                    nodeList.RemoveAt(index);
                }

                set.Add(node);
            }

            return nodeList;
        }
    }
}