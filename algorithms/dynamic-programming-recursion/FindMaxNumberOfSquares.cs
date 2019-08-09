using System;

namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public static class FindMaxNumberOfSquares
    {
        public static int NumSquares(int A, int B)
        {
            var sqrtCountHigher = 0;

            for (var i = A; i <= B; i++)
            {
                var sqrtCount = getSquareCountForSingleNumber(i);

                if (sqrtCountHigher < sqrtCount) sqrtCountHigher = sqrtCount;
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
    }
}