using Shouldly;
using Xunit;

namespace HandsOn.Algorithm.TreesGraphs
{
    public class MinimalTreeTests
    {
        [Fact]
        public void should_build_minimal_tree_simple()
        {
            var input = new int[] { 1, 2, 3 };
            var result = MinimalTree.Create(input);
            result.val.ShouldBe(2);
            result.left.val.ShouldBe(1);
            result.right.val.ShouldBe(3);
        }
        [Fact]
        public void should_build_minimal_tree()
        {
            var input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var result = MinimalTree.Create(input);
            result.val.ShouldBe(4);
            result.left.val.ShouldBe(2);
            result.left.left.val.ShouldBe(1);
            result.left.right.val.ShouldBe(3);
        }
    }
}