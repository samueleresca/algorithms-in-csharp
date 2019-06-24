using System;
using Shouldly;
using Xunit;

namespace HandsOn.Algorithms.ArraysAndStrings.DynamicProgramming
{
    public class LongestCommonRepeatingSubstringTests
    {
        [Fact]
        public static void should_calculate_the_right_longest_common_repeating_substring()
        {
            string s1 = "banana"; 
            LongestCommonRepeatingSubstring.longestRepeatedSubstring(s1).ShouldBe("ana");
        }
    }
}