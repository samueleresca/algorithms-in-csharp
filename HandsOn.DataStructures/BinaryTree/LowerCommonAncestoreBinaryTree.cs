using System.Data;
using Xunit.Sdk;

namespace HandsOn.DataStructures.BinaryTree
{
    public class LowerCommonAncestorBinaryTree
    {
        public Node root { get; set; }

        public class Node
        {
            public int data;
            public Node left;
            public Node right;

            public Node(int item)
            {
                data = item;
                left = right = null;
            }
        }

        public Node findLowerCommonAncestor(int n1, int n2)
        {
            return findLowerCommonAncestor(root, n1, n2);
        }

        private Node findLowerCommonAncestor(Node node, int n1, int n2)
        {
            if (node == null)
            {
                return null;
            }

            // If either n1 or n2 matches with root's key, report 
            // the presence by returning root (Note that if a key is 
            // ancestor of other, then the ancestor key becomes LCA 
            if (node.data == n1 || node.data == n2)
                return node;
            // Look for keys in left and right subtrees 
            var nodeLeft = findLowerCommonAncestor(node.left, n1, n2);
            var nodeRight = findLowerCommonAncestor(node.right, n1, n2);

            // If both of the above calls return Non-NULL, then one key 
            // is present in once subtree and other is present in other, 
            // So this node is the LCA 
            if (nodeLeft != null && nodeRight != null)
                return node;

            // Otherwise check if left subtree or right subtree is LCA 
            return (nodeLeft != null) ? nodeLeft : nodeRight;
        }
    }
}