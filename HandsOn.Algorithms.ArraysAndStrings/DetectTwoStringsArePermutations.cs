using System;

namespace HandsOn.Algorithms.ArraysAndStrings.DynamicProgramming
{
    public static class DetectTwoStringsArePermutations
    {
        static int NO_OF_CHARS = 256;

        /* function to check whether two strings 
        are Permutation of each other */
        public static bool ArePermutation(char[] str1, char[] str2)
        {
            if (str1.Length != str2.Length)
                return false;
            // Create 2 count arrays and initialize 
            // all values as 0 
            int[] count1 = new int[256];
            int[] count2 = new int[256];
            int i;

            // For each character in input strings, 
            // increment count in the corresponding 
            // count array 
            for (i = 0; i < str1.Length && i < str2.Length;
                i++)
            {
                count1[str1[i]]++;
                count2[str2[i]]++;
            }

            // Compare count arrays 
            for (i = 0; i < 256; i++)
                if (count1[i] != count2[i])
                    return false;

            return true;
        }

    }

}
