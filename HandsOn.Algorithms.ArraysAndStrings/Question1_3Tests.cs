using Shouldly;
using Xunit;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class Question1_3Tests
    {
        [Theory]
        [InlineData("tact coa", true)]
        public void should_detect_permutations_of_strings(string input, bool result)
        {
            Question1_3.IsPermutationPalindrome(input).ShouldBe(result);
        }
    }
}
