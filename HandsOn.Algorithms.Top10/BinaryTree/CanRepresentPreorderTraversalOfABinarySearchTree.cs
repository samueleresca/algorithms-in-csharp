using System.Collections.Generic;

namespace HandsOn.Algorithms.Top10.BinaryTree
{
    public class CanRepresentPreorderTraversalOfABinarySearchTree
    {
        /// <summary>
        /// new int[]{40, 30, 35, 80, 100}; 
        /// </summary>
        /// <param name="pre"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public virtual bool canRepresentBST(int[] pre, int n)
        {
            // Create an empty stack  
            Stack<int> stack = new Stack<int>();

            // Initialize current root as minimum  
            // possible value  
            int root = int.MinValue;

            // Traverse given array  
            for (int i = 0; i < n; i++)
            {
                // If we find a node who is on right side  
                // and smaller than root, return false  
                if (pre[i] < root)
                {
                    return false;
                }

                // If pre[i] is in right subtree of stack top,  
                // Keep removing items smaller than pre[i]  
                // and make the last removed item as new  
                // root.  
                while (stack.Count > 0 && stack.Peek() < pre[i])
                {
                    root = stack.Pop();

                }

                // At this point either stack is empty or  
                // pre[i] is smaller than root, push pre[i]  
                stack.Push(pre[i]);
            }

            return true;
        }
    }
}