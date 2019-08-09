using System.Collections.Generic;
using System.Linq;

namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public class QueenProblem
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            var initString = new string('.', n);
            var cols = new string[n];

            for (var i = 0; i < n; i++) cols[i] = initString;


            return placeQueens(n, 0, new List<string>(cols), new List<IList<string>>());
        }

        public IList<IList<string>> placeQueens(int size, int row, List<string> matrix, IList<IList<string>> result)
        {
            if (row == size)
            {
                result.Add(matrix.Select(_ => _.ToString()).ToList());
                return result;
            }

            for (var col = 0; col < size; col++)
            {
                if (!checkValid(matrix, row, col)) continue;

                matrix[row] = matrix[row].Remove(col, 1).Insert(col, "Q");
                placeQueens(size, row + 1, matrix, result);
            }

            return result;
        }

        private bool checkValid(List<string> matrix, int currentRow, int currentColumn)
        {
            var previousRow = currentRow - 1;
            var previousColumn = currentColumn - 1;
            if (previousRow <= 0) return true;


            var upCell = matrix[previousRow].Substring(currentColumn, 1);

            if (upCell == "Q") return false;


            if (previousColumn <= 0) return true;
            var diagonalCell = matrix[previousRow].Substring(previousColumn - 1, 1);

            return diagonalCell != "Q";
        }
    }
}