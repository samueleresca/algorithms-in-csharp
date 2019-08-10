using System;
using arraystringssproblem;
using Xunit;
using Xunit.Abstractions;

namespace arraysstringsproblems
{
    public class RotateMatrixTests
    {
        private ITestOutputHelper _outputHelper;
        public RotateMatrixTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void should_rotate_matrix()
        {
            int N = 4;

            // Test Case 1 
            int[][] mat =
            {
                new [] {1, 2, 3, 4},
                new [] {5, 6, 7, 8},
                new [] {9, 10, 11, 12},
                new []  {13, 14, 15, 16}
            };


            var result = RotateMatrix.Execute(mat);
            displayMatrix(result.Length, result);
        }


        void displayMatrix(int N,
            int[][] mat)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    _outputHelper.WriteLine(" " + mat[i][j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}