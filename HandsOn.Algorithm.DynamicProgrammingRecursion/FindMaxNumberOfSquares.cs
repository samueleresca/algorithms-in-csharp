using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public static class FindMaxNumberOfSquares
    {

        public static int NumSquares(int A, int B)
        {
            var sqrtCountHigher = 0;

            for (int i = A; i <= B; i++)
            {
                var sqrtCount = getSquareCountForSingleNumber(i);
                if (sqrtCountHigher < sqrtCount)
                {
                    sqrtCountHigher = sqrtCount;
                }

            }

            return sqrtCountHigher;
        }

        private static int getSquareCountForSingleNumber(int input, int squareCount = 0)
        {
            var square = (int)Math.Sqrt(input);
            var isSquare = Math.Pow(square, 2) == input;
            if (!isSquare) return squareCount;
            squareCount++;
            return getSquareCountForSingleNumber(square, squareCount);
        }


        public static int solutionEfficient(int A, int B)
        {
            int differences = (int)(Math.Floor(Math.Sqrt(B)) - Math.Ceiling(Math.Sqrt(A)));
            return differences + 1;
        }
    }
}