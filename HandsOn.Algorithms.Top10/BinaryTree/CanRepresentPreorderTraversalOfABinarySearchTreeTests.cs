using Shouldly;
using Xunit;

namespace HandsOn.Algorithms.Top10.BinaryTree
{
    public class CanRepresentPreorderTraversalOfABinarySearchTreeTests
    {
        private CanRepresentPreorderTraversalOfABinarySearchTree sut = new CanRepresentPreorderTraversalOfABinarySearchTree();

        [Fact]
        public void represent_preorder_traversal_of_a_binarysearch_tree()
        {
            int[] pre1 = { 40, 30, 35, 80, 100 };
            var n = pre1.Length;
            sut.canRepresentBST(pre1, n).ShouldBe(true);
        }

        [Fact]
        public void NOT_represent_preorder_traversal_of_a_binary_search_tree()
        {
            int[] pre1 = { 40, 30, 35, 20, 80, 100 };
            var n = pre1.Length;
            sut.canRepresentBST(pre1, n).ShouldBe(false);
        }
    }
}