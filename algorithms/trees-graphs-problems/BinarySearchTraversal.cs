using System;
using System.Collections.Generic;
using Xunit;

namespace HandsOn.Algorithm.TreesGraphs
{
    public class BinarySearchTraversal
    {
        public void InOrderTraversal(Node<int> node)
        {
            if (node == null) return;

            InOrderTraversal(node.Left);
            var getValue = node.Value;
            InOrderTraversal(node.Right);
        }

        public void PreOrderTraversal(Node<int> node)
        {
            if (node == null) return;

            var getValue = node.Value;
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }

        public void PostOrderTraversal(Node<int> node)
        {
            if (node == null) return;

            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            var getValue = node.Value;

        }

        public IList<int> PostorderTraversal(TreeNode root)
        {
            var myList = new List<int>();

            if (root == null)
            {
                return myList;
            }

            PostOrderHandler(root, myList);
            return myList;
        }

        private void PostOrderHandler(TreeNode root, List<int> myList)
        {
            if (root == null)
            {
                return;
            }
            
            PostOrderHandler(root.left, myList);
            PostOrderHandler(root.right, myList);
            
            myList.Add(root.val);
        }



        public class Tree
        {
            public Node<int> root;
        }

        public class Node<T>
        {
            public T Value;
            public Node<T> Left;
            public Node<T> Right;
        }
    }
}