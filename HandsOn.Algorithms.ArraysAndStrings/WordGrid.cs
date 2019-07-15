using System;
using System.Runtime.CompilerServices;
using Xunit.Abstractions;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class WordGrid
    {
        public bool Exist(char[][] board, string word, ITestOutputHelper testOutputHelper)
        {

            var rowLength = board.GetLength(0);
            var columnLength = board[0].Length;

            for (int rowIndex = 0; rowIndex < rowLength; rowIndex++)
            {

                for (int columnIndex = 0; columnIndex < columnLength; columnIndex++)
                {
                    if (search2D(board, rowIndex, columnIndex, word, testOutputHelper))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool search2D(char[][] grid, int row,
            int col, string word, ITestOutputHelper testOutputHelper)
        {

            var y = new int[] { 1, 0, -1, 0 };
            var x = new int[] { 0, 1, 0, 1 };

            if (grid[row][col] != word[0])
                return false;

            int k = 1, rd = 0, cd = 0;
            rd = row;
            cd = col;

            for (int currentDir = 0; currentDir < 4; currentDir++)
            {
                if (rd >= grid.GetLength(0) || rd < 0 || cd >= grid[0].Length || cd < 0)
                    continue;
                if (grid[rd][cd] != word[k])
                    continue;

                testOutputHelper.WriteLine(grid[rd][cd].ToString());

                rd += x[currentDir];
                cd += y[currentDir];

                currentDir = 0;
                k++;
            }
            return k == word.Length - 1;
        }
    }
}