using System.Collections.Generic;

namespace HandsOn.Algorithm.TreesGraphs
{
    public class RouteBetweenNodes
    {
        public enum State
        {
            Unvisited,
            Visited,
            Visiting
        }

        private static bool IsConnected(Graph g, Node start, Node end)
        {
            if (start == end) return true;

            var q = new Queue<Node>();

            // Set all to State.Unvisited
            foreach (var node in g.getNodes()) node.State = State.Unvisited;

            start.State = State.Visiting;

            q.Enqueue(start);

            while (q.Count > 0)
            {
                var u = q.Dequeue();

                if (u == null) continue;
                foreach (var v in u.Childrens)
                {
                    if (v.State != State.Unvisited) continue;
                    if (v == end) return true;

                    v.State = State.Visiting;
                    q.Enqueue(v);
                }

                u.State = State.Visited;
            }

            return false;
        }

        private class Graph
        {
            private Node[] nodes;

            public Node[] getNodes()
            {
                return nodes;
            }
        }

        public class Node
        {
            public Node[] Childrens;
            public string Name;
            public State State;
        }
    }
}