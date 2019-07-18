using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Xunit.Abstractions;

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
                    if (board[rowIndex][columnIndex] == word[0]
                        && dfs(board, rowIndex, columnIndex, 0, word))
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        private bool dfs(char[][] board, int rowIndex, int columnIndex, int count, string word)
        {

            //CHECK IT REACHED THE END OF THE WORD
            if (count == word.Length)
            {
                return true;
            }

            //CECK OUT OF BUNDARIES
            if (rowIndex < 0 || rowIndex >= board.Length ||
                columnIndex < 0 || columnIndex >= board[rowIndex].Length)
            {
                return false;
            }

            //CHECK IF THE CHAR IS DIFFERENT FROM THE CURRENT ONE
            if (board[rowIndex][columnIndex] != word[count])
            {
                return false;
            }


            var temp = board[rowIndex][columnIndex];
            board[rowIndex][columnIndex] = ' ';

            var found = dfs(board, rowIndex + 1, columnIndex, count + 1, word)
                            || dfs(board, rowIndex - 1, columnIndex, count + 1, word)
                            || dfs(board, rowIndex, columnIndex + 1, count + 1, word)
                            || dfs(board, rowIndex, columnIndex - 1, count + 1, word);

            board[rowIndex][columnIndex] = temp;


            return found;
        }
    }
}