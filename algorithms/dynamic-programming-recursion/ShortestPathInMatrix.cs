using System.Collections.Generic;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class ShortestPathInMatrix
    {
        public int ShortestPathBinaryMatrix(int[][] grid)
        {
            int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };

            if (grid[0][0] == 1) return -1;

            var queue = new Queue<Cell>();
            var visited = new bool[grid.Length, grid.Length];

            queue.Enqueue(new Cell(0, 0, 1));

            while (queue.Count > 0)
            {
                // Get and Remove
                var front = queue.Dequeue();
                var cx = front.x;
                var cy = front.y;
                var lvl = front.lvl;

                // If is visited, skip 
                if (visited[cx, cy])
                    continue;

                visited[cx, cy] = true;

                // Final step
                if (cx == grid.Length - 1 && cy == grid.Length - 1) return lvl;

                // Visit 
                for (var i = 0; i < 8; i++)
                {
                    var px = cx + dx[i];
                    var py = cy + dy[i];

                    if (isInBounds(px, py, grid.Length)
                        && !visited[px, py]
                        && grid[px][py] == 0)
                        queue.Enqueue(new Cell(px, py, lvl + 1));
                }
            }

            return -1;
        }

        private bool isInBounds(int x, int y, int length)
        {
            return x >= 0 && x < length && y >= 0 && y < length;
        }

        public class Cell
        {
            public int lvl;
            public int x;
            public int y;

            public Cell(int x, int y, int lvl)
            {
                this.x = x;
                this.y = y;
                this.lvl = lvl;
            }
        }
    }
}