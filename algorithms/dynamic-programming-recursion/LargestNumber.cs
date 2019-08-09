using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public static class LargestNumber
    {
        public static string Calc(int[] nums)
        {
            var stringNums = nums.Select(_ => _.ToString()).ToArray();
            Array.Sort(stringNums, new CustomStringComparer());

            var finalResult = stringNums.Aggregate((i, j) => i + j);

            return finalResult.All(x => x == '0') ? "0" : finalResult;
        }
    }

    internal class CustomStringComparer : IComparer<string>
    {
        public int Compare(string string1, string string2)
        {
            var order1 = string1 + string2;
            var order2 = string2 + string1;
            return double.Parse(order2).CompareTo(double.Parse(order1));
        }
    }
}