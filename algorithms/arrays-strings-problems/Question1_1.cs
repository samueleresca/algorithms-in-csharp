using System.Collections.Generic;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public static class Question1_1
    {
        // O(n) complexity 
        public static bool IsUnique(string str)
        {
            var charSet = new Dictionary<char, bool>();

            for (var index = 0; index < str.ToCharArray().Length; index++)
            {
                var @char = str.ToCharArray()[index];
                if (charSet.TryGetValue(@char, out _))
                {
                    return false;
                }

                charSet.Add(@char, true);
            }

            return true;
        }

        public static bool IsUniqueUsingBit(string str)
        {
            int checker = 0;

            for (var index = 0; index < str.ToCharArray().Length; index++)
            {
                int val = str.ToCharArray()[index] - 'a';

                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }

                checker |= (1 << val);
            }

            return true;
        }
    }
}
