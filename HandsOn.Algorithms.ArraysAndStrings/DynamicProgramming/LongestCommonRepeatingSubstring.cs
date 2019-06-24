using System;
using System.Collections.Generic;

namespace HandsOn.Algorithms.ArraysAndStrings.DynamicProgramming
{
    public static class LongestCommonRepeatingSubstring
    {
       // "banana"
       // "ana"
        // Returns the longest repeating non-overlapping  
// substring in str  
           public static String longestRepeatedSubstring(String str)
           {
               var checkWords = new Dictionary<string, int>();
               var j = 2;
               var lastWord = "";

               while (j < str.Length)
               {
                   for (int i = 0; i < str.Length - (j-1); i++ )
                   {
                       if (!checkWords.TryAdd(str.Substring(i, j), i))
                       {
                           lastWord = str.Substring(i, j);
                       }
                   
                   }

                   j++;
               }
              

               return lastWord;
           } 
    }
}