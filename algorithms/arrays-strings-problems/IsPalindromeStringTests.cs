using Shouldly;
using Xunit;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class IsPalindromeStringTests
    {
        [Fact]
        public void should_detect_not_palindrome_string()
        {
            IsPalindromeString.Execute("aska").ShouldBeFalse();
        }

        [Fact]
        public void should_detect_palindrome_string()
        {
            IsPalindromeString.Execute("akka").ShouldBeTrue();
        }
    }
}