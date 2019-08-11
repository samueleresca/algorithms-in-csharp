using System;
using Shouldly;
using Xunit;

namespace HandsOn.Algorithm.TreesGraphs
{
    public class ListOfDepthsTests
    {

        [Fact]
        public void should_return_the_right_list_of_levels()
        {
            var classes = new ListOfDepths();

            var root = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
            };

            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            var result = classes.Execute(root);

            result.ShouldNotBeNull();

            result[0][0].ShouldBe(3);
            result[1][0].ShouldBe(9);
            result[1][1].ShouldBe(20);
            result[2][0].ShouldBe(15);
            result[2][1].ShouldBe(7);
        }

        [Fact]
        public void should_handle_empty_list()
        {
            var classes = new ListOfDepths();

            TreeNode root = null;
            var result = classes.Execute(root);

            result.ShouldNotBeNull();
        }
    }
}