using Shouldly;
using Xunit;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class Question1_2Tests
    {
        [Theory]
        [InlineData("asdf", "asdf", true)]
        [InlineData("asdf", "sdaf", true)]
        [InlineData("asdf", "ss", false)]
        public void should_detect_permutations_of_strings(string input1, string input2, bool result)
        {
            Question1_2.IsPermutation(input1, input2).ShouldBe(result);
        }

        [Theory]
        [InlineData("asdf", "asdf", true)]
        [InlineData("asdf", "sdaf", true)]
        [InlineData("asdf", "ss", false)]
        public void should_detect_permutations_of_strings_using_hash_tables(string input1, string input2, bool result)
        {
            Question1_2.IsPermutationUsingHashTable(input1, input2).ShouldBe(result);
        }
    }
}
