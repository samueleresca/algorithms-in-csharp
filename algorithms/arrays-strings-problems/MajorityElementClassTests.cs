using System.Collections.Generic;
using Shouldly;
using Xunit;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class MajorityElementClassTests
    {
        [Fact]
        public void should_return_the_right_result()
        {
            var input = new[] { 3, 2, 3 };
            MajorityElementClass.GetMajorityElements(input).ShouldBe(new List<int> { 3 });
        }

        [Fact]
        public void should_return_the_right_result_2()
        {
            var input = new[]
            {
                1, 1, 1, 3, 3, 2, 2, 2
            };

            MajorityElementClass.GetMajorityElements(input).ShouldBe(new List<int> { 1, 2 });
        }
    }
}