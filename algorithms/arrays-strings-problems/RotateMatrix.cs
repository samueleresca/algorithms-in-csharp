using System;

namespace arraystringssproblem
{
    public static class RotateMatrix
    {

        public static int[][] Execute(int[][] matrix)
        {
            if (matrix.Length == 0) return matrix;
            if (matrix.Length != matrix[0].Length) return matrix;

            var length = matrix.Length;

            for (int layer = 0; layer < length / 2; layer++)
            {
                int first = layer;
                int last = length - 1 - layer;

                for (int i = first; i < last; i++)
                {
                    var offset = i - first;
                    var top = matrix[first][i]; //save top;

                    //left -> top
                    matrix[first][i] = matrix[last - offset][first];
                    //bottom -> left
                    matrix[last - offset][first] = matrix[last][last - offset];
                    //right -> bottom
                    matrix[last][last - offset] = matrix[i][last];
                    //top -> right
                    matrix[i][last] = top;

                }
            }

            return matrix;
        }


    }
}