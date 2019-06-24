using System;
using Shouldly;
using Xunit;

namespace HandsOn.Algorithms.ArraysAndStrings.DynamicProgramming
{
    public static class LongestCommonSubsequenceTests
    {

        [Fact]
        public static void should_calculate_the_right_longest_common_subsequence()
        {
            String s1 = "AGGTAB"; 
            String s2 = "GXTXAYB"; 
            LongestCommonSubsequence.Execute(s1, s2).ShouldBe(4);
            
        }
    }
}