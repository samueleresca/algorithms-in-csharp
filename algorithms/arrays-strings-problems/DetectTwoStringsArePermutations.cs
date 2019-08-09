namespace HandsOn.Algorithms.ArraysAndStrings
{
    public static class DetectTwoStringsArePermutations
    {
        private static readonly int NO_OF_CHARS = 128;

        public static bool Execute(char[] str1, char[] str2)
        {
            if (str1.Length != str2.Length)
                return false;

            var charCount = new int[NO_OF_CHARS];

            for (var i = 0; i < str1.Length && i < str2.Length; i++) charCount[str1[i]]++;

            for (var i = 0; i < str2.Length; i++)
            {
                charCount[str2[i]]--;
                if (charCount[i] != 0)
                    return false;
            }

            return true;
        }
    }
}