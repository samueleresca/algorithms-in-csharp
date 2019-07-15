using Shouldly;
using Xunit;

namespace HandsOn.Algorithms.ArraysAndStrings
{

    public class IsPalindromeStringTests
    {

        [Fact]
        public void should_detect_palindrome_string()
        {
            IsPalindromeString.IsPalindrome("akka").ShouldBeTrue();
        }

        [Fact]
        public void should_detect_not_palindrome_string()
        {
            IsPalindromeString.IsPalindrome("aska").ShouldBeFalse();
        }
    }
}