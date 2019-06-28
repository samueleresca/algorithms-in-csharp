using Shouldly;
using Xunit;
using Node = HandsOn.Algorithms.Top10.BinaryTree.LowerCommonAncestorBinaryTree.Node;

namespace HandsOn.Algorithms.Top10.BinaryTree
{
    public class LowerCommonAncestorBinaryTreeTests
    {
        public LowerCommonAncestorBinaryTree tree;


        public LowerCommonAncestorBinaryTreeTests()
        {
            tree = new LowerCommonAncestorBinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            tree.root.right.left = new Node(6);
            tree.root.right.right = new Node(7);
        }

        [Theory]
        [InlineData(4, 5, 2)]
        [InlineData(4, 6, 1)]
        [InlineData(3, 4, 1)]
        [InlineData(2, 4, 2)]
        public void should_find_the_right_lower_common_ancestor(int n1, int n2, int result)
        {
            tree.findLowerCommonAncestor(n1, n2).data.ShouldBe(result);
        }
    }
}