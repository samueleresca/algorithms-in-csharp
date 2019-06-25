using HandsOn.Algorithms.ArraysAndStrings.DynamicProgramming;
using Shouldly;
using Xunit;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class DetectTwoStringsArePermutationsTests
    {
        [Theory]
        [InlineData("asd", "das", true)]
        [InlineData("asd", "dass", false)]
        [InlineData("bee", "eeb", true)]
        [InlineData("qwerty", "ytrewq", true)]
        public void strings_are_permutations(string str1, string str2, bool result)
        {
            DetectTwoStringsArePermutations.ArePermutation(str1.ToCharArray(), str2.ToCharArray()).ShouldBe(result);
        }
    }
}
