using Shouldly;
using Xunit;
using Node = HandsOn.DataStructures.BinaryTree.LowerCommonAncestorBinarySearchTree.Node;


namespace HandsOn.DataStructures.BinaryTree
{
    public class LowerCommonAncestorBinarySearchTreeTests
    {

        private LowerCommonAncestorBinarySearchTree tree;

        public LowerCommonAncestorBinarySearchTreeTests()
        {
            tree = new LowerCommonAncestorBinarySearchTree();

            tree.root = new Node(20);
            tree.root.left = new Node(8);
            tree.root.right = new Node(22);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(12);
            tree.root.left.right.left = new Node(10);
            tree.root.left.right.right = new Node(14);
        }


        [Theory]
        [InlineData(10, 14, 12)]
        [InlineData(14, 8, 8)]
        [InlineData(10, 22, 20)]
        public void should_find_the_right_lower_common_ancestor(int n1, int n2, int result)
        {
            tree.FindLowerCommonAncestor(n1, n2).ShouldBe(result);
        }
    }
}