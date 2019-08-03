using Shouldly;
using Xunit;
using Node = HandsOn.Algorithms.Top10.BinaryTree.BreadthFirstTraversal.Node;

namespace HandsOn.Algorithms.Top10.BinaryTree
{
    public class BreadthFirstTraversalTests
    {

        private BreadthFirstTraversal tree;

        public BreadthFirstTraversalTests()
        {
            tree = new BreadthFirstTraversal();

            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
        }


        [Fact]
        public void should_find_the_right_lower_common_ancestor()
        {
            tree.findBFT().ShouldBe(new[] { 1, 2, 3, 4, 5 });
        }
    }
}