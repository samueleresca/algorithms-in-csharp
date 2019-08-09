namespace HandsOn.Algorithms.ArraysAndStrings
{
    public static class IsPalindromeString
    {
        public static bool Execute(string input)
        {
            var l = 0;
            var h = input.Length - 1;

            while (h > l)
                if (input[l++] != input[h--])
                    return false;

            return true;
        }
    }
}