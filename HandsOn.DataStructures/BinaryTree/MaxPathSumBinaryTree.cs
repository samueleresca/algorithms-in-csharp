using System;

namespace HandsOn.DataStructures.BinaryTree
{
    public static class MaxPathSumBinaryTree
    {
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

        public class BinaryTree
        {
            //Root of the Binary Tree  
            public Node root;

            int findMaxUtil(Node node, ref int value)
            {
                // Base Case 
                if (node == null)
                    return 0;
                // l and r store maximum path 
                // sum going through left and 
                // right child of root respectively 
                int l = findMaxUtil(node.left, ref value);
                int r = findMaxUtil(node.right, ref value);

                // Max path for parent call of root.  
                // This path must include  
                // at-most one child of root 
                int max_single = Math.Max(Math.Max(l, r) +
                                          node.data, node.data);


                // Max Top represents the sum 
                // when the Node under 
                // consideration is the root  
                // of the maxsum path and no 
                // ancestors of root are there  
                // in max sum path 
                int max_top = Math.Max(max_single,
                    l + r + node.data);

                // Store the Maximum Result. 
                value = Math.Max(value, max_top);

                return max_single;
            }


            public int findMaxSum()
            {
                return findMaxSum(root);
            }

            // Returns maximum path  
            // sum in tree with given root 
            int findMaxSum(Node node)
            {

                int value = 0;
                // Compute and return result 
                findMaxUtil(node, ref value);
                return value;
            }
        }
    }
}