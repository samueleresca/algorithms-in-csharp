namespace HandsOn.Algorithms.ArraysAndStrings
{
    public static class CheckPermutationPalindrome
    {
        //O (N)
        public static bool Execute(string input)
        {
            var table = BuildCharFrequencyTable(input);
            return CheckMaxOneOdd(table);
        }

        private static bool CheckMaxOneOdd(int[] table)
        {
            var foundOdd = false;
            foreach (var count in table)
            {
                if (count % 2 != 1) continue;
                if (foundOdd) return false;

                foundOdd = true;
            }

            return true;
        }

        private static int[] BuildCharFrequencyTable(string input)
        {
            var table = new int['z' - 'a' + 1];
            foreach (var c in input.ToCharArray())
            {
                var x = (int)char.GetNumericValue(c);
                if (x != -1) table[x]++;
            }

            return table;
        }
    }
}