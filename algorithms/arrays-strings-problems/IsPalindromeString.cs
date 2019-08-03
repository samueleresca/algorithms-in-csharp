namespace HandsOn.Algorithms.ArraysAndStrings
{
    public static class IsPalindromeString
    {

        public static bool IsPalindrome(string input)
        {
            int l = 0;
            int h = input.Length - 1;

            while (h > l)
            {
                if (input[l++] != input[h--])
                {
                    return false;
                }
            }

            return true;
        }
    }

}