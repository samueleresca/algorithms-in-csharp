using Shouldly;
using Xunit;

namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public class LongestCommonRepeatingSubstringTests
    {
        [Fact]
        public static void should_calculate_the_right_longest_common_repeating_substring()
        {
            var s1 = "banana";
            LongestCommonRepeatingSubstring.longestRepeatedSubstring(s1).ShouldBe("ana");
        }
    }
}