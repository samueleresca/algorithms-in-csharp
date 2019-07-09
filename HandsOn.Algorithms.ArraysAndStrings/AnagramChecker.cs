using System;
using System.Linq;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class AnagramChecker
    {
        public bool IsAnagram(string s, string t)
        {

            if (s.Length != t.Length) return false;

            var count1 = new int[256];
            var count2 = new int[256];

            for (var i = 0; i < s.Length && i < t.Length;
                i++)
            {
                count1[s[i]]++;
                count2[t[i]]++;
            }


            for (int i = 0; i < count1.Length; i++)
            {
                if (count1[i] != count2[i])
                {
                    return false;
                }
            }

            return true;
        }


        public bool IsAnagramOlogN(string s, string t)
        {
            // Get lenghts of both strings 
            int n1 = s.Length;
            int n2 = t.Length;

            // If length of both strings is not 
            // same, then they cannot be anagram 
            if (n1 != n2)
            {
                return false;
            }

            var sArr = s.ToCharArray();
            var tArr = t.ToCharArray();
            // Sort both strings 
            Array.Sort(sArr);
            Array.Sort(tArr);

            // Compare sorted strings 
            for (int i = 0; i < n1; i++)
            {
                if (sArr[i] != tArr[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}