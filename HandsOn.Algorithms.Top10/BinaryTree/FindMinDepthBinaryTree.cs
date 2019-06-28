using System;

namespace HandsOn.Algorithms.Top10.BinaryTree
{
    public class FindMinDepthBinaryTree
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

            public virtual int minimumDepthBasic()
            {
                return minimumDepthBasic(root);
            }

            public virtual int minimumDepthLevel()
            {
                return minimumDepthLevel(root, 0);
            }

            // O(n)
            public virtual int minimumDepthBasic(Node root)
            {
                if (root == null)
                {
                    return 0;
                }

                if (root.left == null && root.right == null)
                {
                    return 1;
                }

                if (root.left == null)
                {
                    return minimumDepthBasic(root.right) + 1;
                }

                if (root.right == null)
                {
                    return minimumDepthBasic(root.left) + 1;
                }

                return Math.Min(minimumDepthBasic(root.left), minimumDepthBasic(root.right)) + 1;
            }

            public virtual int minimumDepthLevel(Node root, int level)
            {
                if (root == null)
                {
                    return level;
                }

                level++;

                return Math.Min(minimumDepthLevel(root.left, level),
                    minimumDepthLevel(root.right, level));
            }
        }


    }


}