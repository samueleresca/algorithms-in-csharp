using Shouldly;
using Xunit;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class Question1_1Tests
    {
        [Theory]
        [InlineData("asdf", true)]
        [InlineData("aaa", false)]
        [InlineData("sadjaskdkkkk", false)]
        [InlineData("samuel", true)]
        public void should_detect_string_of_unique_characters_bit_version(string input, bool result)
        {
            Question1_1.IsUniqueUsingBit(input).ShouldBe(result);
        }

        [Theory]
        [InlineData("asdf", true)]
        [InlineData("aaa", false)]
        [InlineData("sadjaskdkkkk", false)]
        [InlineData("samuel", true)]
        public void should_detect_string_of_unique_characters(string input, bool result)
        {
            Question1_1.IsUnique(input).ShouldBe(result);
        }
    }
}
