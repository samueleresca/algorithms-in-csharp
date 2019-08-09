using Shouldly;
using Xunit;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class CheckPermutationPalindromeTests
    {
        [Theory]
        [InlineData("tact coa", true)]
        public void should_detect_permutations_of_strings(string input, bool result)
        {
            CheckPermutationPalindrome.Execute(input).ShouldBe(result);
        }
    }
}