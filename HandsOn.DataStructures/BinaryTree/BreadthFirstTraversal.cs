using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace HandsOn.DataStructures.BinaryTree
{
    public class BreadthFirstTraversal
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

        public int[] findBFT()
        {
            return findBFT(root);
        }

        public virtual int[] findBFT(Node root)
        {

            Queue<Node> queue = new Queue<Node>();
            var values = new List<Node> { };

            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var tempNode = queue.Dequeue();
                values.Add(tempNode);

                /*Enqueue left child */
                if (tempNode.left != null)
                {
                    queue.Enqueue(tempNode.left);
                }

                /*Enqueue right child */
                if (tempNode.right != null)
                {
                    queue.Enqueue(tempNode.right);
                }
            }


            return values.Select(x => x.data).ToArray();
        }
    }
}