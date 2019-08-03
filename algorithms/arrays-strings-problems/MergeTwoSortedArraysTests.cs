using Shouldly;
using Xunit;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class MergeTwoSortedArraysTests
    {
        [Fact]
        public void should_return_the_right_merged_array()
        {
            var array1 = new[] { 1, 2, 3, 0, 0, 0 };
            var m = 3;
            var array2 = new[] { 2, 5, 6 };
            var n = 3;

            MergeTwoSortedArrays.Merge(array1, m, array2, n);

            array1.ShouldBe(new int[]
        {
                1,2,2,3,5,6
        });

        }
    }
}