using Xunit.Sdk;

namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public class Coins
    {
        public int CalculateNumberOfWays(int n, int[] denoms)
        {
            var map = new int[n + 1, denoms.Length];
            return makeChangeHelper(n, denoms, 0, map);
        }

        private int makeChangeHelper(int total, int[] denoms, int index, int[,] map)
        {
            if (map[total, index] > 0)
            {
                return map[total, index];
            }

            var coin = denoms[index];

            if (index == denoms.Length - 1)
            {
                var remaining = total % coin;
                return remaining == 0 ? 1 : 0;
            }

            int numberOFWays = 0;

            for (int amount = 0; amount <= total; amount += coin)
            {
                numberOFWays += makeChangeHelper(total - amount, denoms, index + 1, map);
            }

            map[total, index] = numberOFWays;

            return numberOFWays;
        }
    }
}