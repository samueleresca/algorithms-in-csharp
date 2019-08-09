using Shouldly;
using Xunit;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public static class StringIsUniqueTests
    {
        [Theory]
        [InlineData("aa", false)]
        [InlineData("abc", true)]
        [InlineData("asadasdasdasd", false)]
        [InlineData("qwertyuiopasdfghjklzxcvbnm", true)]
        public static void should_detect_unique_strings(string s, bool result)
        {
            StringIsUnique.Execute(s).ShouldBe(result);
        }
    }
}