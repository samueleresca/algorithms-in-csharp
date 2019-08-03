using System.Collections.Generic;
using System.Linq;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public static class Question1_2
    {
        public static bool IsPermutation(string input1, string input2)
        {
            return input1.Length == input2.Length && Sort(input1).Equals(Sort(input2));
        }

        private static string Sort(string input)
        {
            var orderedEnumerable = input.ToCharArray().OrderBy(_ => _).ToArray();
            return new string(orderedEnumerable);
        }

        public static bool IsPermutationUsingHashTable(string input1, string input2)
        {
            if (input1.Length != input2.Length) return false;

            var letters = new Dictionary<char, int>();

            foreach (var t in input1)
            {
                letters.TryGetValue(t, out var currentCount);
                letters[t] = currentCount + 1;
            }

            foreach (var t in input2)
            {
                letters.TryGetValue(t, out var currentCount);
                letters[t] = currentCount - 1;

                if (letters[t] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
