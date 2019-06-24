using Shouldly;
using Xunit;
using Node = HandsOn.DataStructures.BinaryTree.MaxPathSumBinaryTree.Node;


namespace HandsOn.DataStructures.BinaryTree
{
    public class MaxPathSumBinaryTreeTests
    {
        private readonly MaxPathSumBinaryTree.BinaryTree tree;

        public MaxPathSumBinaryTreeTests()
        {
            tree = new MaxPathSumBinaryTree.BinaryTree();
            tree.root = new Node(10);
            tree.root.left = new Node(2);
            tree.root.right = new Node(10);
            tree.root.left.left = new Node(20);
            tree.root.left.right = new Node(1);
            tree.root.right.right = new Node(-25);
            tree.root.right.right.left = new Node(3);
            tree.root.right.right.right = new Node(4);
        }

        [Fact]
        public void Should_calc_the_right_max_sum()
        {
            tree.findMaxSum().ShouldBe(42);
        }
    }
}