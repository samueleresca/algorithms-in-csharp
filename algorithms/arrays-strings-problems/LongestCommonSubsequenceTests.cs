using Shouldly;
using Xunit;

namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public static class LongestCommonSubsequenceTests
    {
        [Fact]
        public static void should_calculate_the_right_longest_common_subsequence()
        {
            var s1 = "AGGTAB";
            var s2 = "GXTXAYB";
            LongestCommonSubsequence.Execute(s1, s2).ShouldBe(4);
        }
    }
}