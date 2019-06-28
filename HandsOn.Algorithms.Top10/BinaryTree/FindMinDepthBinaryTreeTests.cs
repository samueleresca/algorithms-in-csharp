using Shouldly;
using Xunit;
using Node = HandsOn.Algorithms.Top10.BinaryTree.FindMinDepthBinaryTree.Node;

namespace HandsOn.Algorithms.Top10.BinaryTree
{
    public class FindMinDepthBinaryTreeTests
    {
        private readonly FindMinDepthBinaryTree.BinaryTree tree;

        public FindMinDepthBinaryTreeTests()
        {
            tree = new FindMinDepthBinaryTree.BinaryTree { root = new Node(1) };

            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
        }

        [Fact]
        public void Should_calc_the_right_min_depth_using_basic()
        {
            tree.minimumDepthBasic().ShouldBe(2);
        }

        [Fact]
        public void Should_calc_the_right_min_depth_using_level()
        {
            tree.minimumDepthBasic().ShouldBe(2);
        }
    }
}