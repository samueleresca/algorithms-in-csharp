using System;

namespace HandsOn.Algorithms.Top10
{
    public class AdjacentPairs
    {
        public int Solution(int[] A)
        {
            if (A.Length < 2)
            {
                return -2;
            }
            int min = A[1] - A[0];
            for (int i = 0; i < A.Length - 1; i++)
            {
                var currentDifference = Math.Abs(A[i + 1] - A[i]);

                if (min > currentDifference)
                {
                    min = currentDifference;
                }
            }

            if (min > 1000000000)
                return -1;

            return min;
        }
    }
}