using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public static class PermutationStrings
    {
        public static bool IsInclusion(string s1, string s2)
        {
            var s1CharArray = s1.ToCharArray();
            Array.Sort(s1CharArray);

            s1 = new string(s1CharArray);

            if (s1.Length > s2.Length)
            {
                return false;
            }

            if (s1 == s2)
            {
                return true;
            }

            var palindromeLength = s1.Length;

            for (int i = 0; i <= s2.Length; i = i + 1)
            {
                if (i + palindromeLength > s2.Length) return false;

                var charArray = s2.Substring(i, palindromeLength);

                if (isPermutation(charArray, s1))
                {
                    return true;
                }

            }
            return false;
        }

        private static bool isPermutation(String a, String b)
        {
            char[] aArray = a.ToCharArray();
            Array.Sort(aArray);
            return new string(aArray) == b;
        }
    }
}