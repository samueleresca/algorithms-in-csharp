using Shouldly;
using Xunit;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class GroupsAnagramsTests
    {

        [Fact]
        public void should_return_right_groups()
        {
            var input = new string[] {"eat", "tea", "tan", "ate", "nat", "bat"};
                new GroupAnagrams().Group(input).Count.ShouldBe(3);
        }
    }
}