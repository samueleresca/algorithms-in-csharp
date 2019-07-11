using System;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class WordGrid
    {
        public bool Exist(char[][] board, string word)
        {

            var rowLength = board.GetLength(0);
            var columnLength = board[0].Length;

            for (int rowIndex = 0; rowIndex < rowLength; rowIndex++)
            {

                for (int columnIndex = 0; columnIndex < columnLength; columnIndex++)
                {
                    if (search2D(board, rowIndex, columnIndex, word))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool search2D(char[][] grid, int row,
            int col, string word)
        {

            var x = new int[] { -1, 0, 1, 0 };
            var y = new int[] { 0, -1, 0, 1 };

            if (grid[row][col] != word[0])
                return false;

            for (int dir = 0; dir < 4; dir++)
            {
                int k, rd = row + x[dir], cd = col + y[dir];

                for (k = 1; k < word.Length; k++)
                {
                    if (rd >= grid.GetLength(0) || rd < 0 || cd >= grid[0].Length || cd < 0)
                        break;
                    if (grid[rd][cd] != word[k])
                        break;

                    rd += x[dir];
                    cd += y[dir];
                }
                if (k == word.Length - 1)
                    return true;

            }
            return false;
        }
    }
}