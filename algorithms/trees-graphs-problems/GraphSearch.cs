using System;
using System.Collections.Generic;

namespace HandsOn.Algorithm.TreesGraphs
{
    public static class GraphSearch
    {

        static void DepthFirstSearch(Node root)
        {
            if (root == null) return;
            var getName = root.Name;
            root.Visited = true;

            foreach (var child in root.Childrens)
            {

                if (!child.Visited)
                {
                    DepthFirstSearch(child);
                }
            }
        }

        static void BreadthFirstSearch(Node root)
        {
            var queue = new Queue<Node>();
            root.Visited = true;
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var r = queue.Dequeue();
                var getValue = r.Name;

                foreach (var n in r.Childrens)
                {
                    if (n.Visited) continue;
                    n.Visited = true;
                    queue.Enqueue(n);
                }

            }
        }

        class Graph
        {
            public Node[] nodes;
        }

        class Node
        {
            public String Name;
            public Node[] Childrens;
            public bool Visited;
        }
    }


}