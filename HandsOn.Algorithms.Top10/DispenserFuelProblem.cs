using System.Collections.Generic;
using System.Linq;

namespace HandsOn.Algorithms.Top10
{
    public class DispenserFuelProblem
    {

        public int solution(int[] A, int X, int Y, int Z)
        {
            var queue = new Queue<int>(A);
            var fuelTanks = new int[] { X, Y, Z };
            var maxWait = -1;

            while (queue.Any() && queue.Count >= fuelTanks.Length)
            {
                for (int i = 0; i < fuelTanks.Length; i++)
                {
                    var result = queue.Dequeue();

                    if (fuelTanks[i] <= result) continue;
                    fuelTanks[i] = fuelTanks[i] - result;
                    if (maxWait < result) maxWait = result;
                }
            }

            return maxWait;
        }
    }
}