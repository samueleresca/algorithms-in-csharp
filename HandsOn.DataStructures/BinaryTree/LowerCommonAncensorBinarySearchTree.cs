namespace HandsOn.DataStructures.BinaryTree
{
    public class LowerCommonAncestorBinarySearchTree
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

        public int FindLowerCommonAncestor(int n1, int n2)
        {
            return findLowerCommonAncestor(root, n1, n2);
        }

        private int findLowerCommonAncestor(Node root, int n1, int n2)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.left == null && root.right == null)
            {
                return root.data;
            }


            if (root.data > n1 && root.data > n2)
            {
                return findLowerCommonAncestor(root.left, n1, n2);
            }

            if (root.data < n1 && root.data < n2)
            {
                return findLowerCommonAncestor(root.right, n1, n2);
            }

            return root.data;
        }

    }
}