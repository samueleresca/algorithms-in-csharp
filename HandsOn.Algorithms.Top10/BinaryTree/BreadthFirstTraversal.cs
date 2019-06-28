using System.Collections.Generic;
using System.Linq;

namespace HandsOn.Algorithms.Top10.BinaryTree
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

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var indexGrouped = new Dictionary<int, List<string>>();
            IList<IList<string>> result = new List<IList<string>>();
            foreach (var str in strs)
            {
                var charCount = str.ToCharArray().Sum(x => (int)x);
                if (indexGrouped.ContainsKey(charCount))
                {
                    indexGrouped[charCount].Add(str);
                    continue;

                }

                var newList = new List<string> { str };
                indexGrouped.Add(charCount, newList);
            }


            foreach (var key in indexGrouped)
            {
                result.Add(indexGrouped[key.Key]);
            }

            return result;
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