namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public static class LongestCommonSubsequence
    {
        public static int Execute(string input1, string input2)
        {
            var input1size = input1.Length;
            var input2size = input2.Length;
            int[,] L = new int[input1size + 1, input2size + 1];

            for (int i = 0; i <= input1size; i++)
            {
                for (int j = 0; j <= input2size; j++)
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 0;
                    else if (input1[i - 1] == input2[j - 1])
                        L[i, j] = L[i - 1, j - 1] + 1;
                    else
                        L[i, j] = L[i - 1, j] > L[i, j - 1] ? L[i - 1, j] : L[i, j - 1];
                }
            }

            return L[input1size, input2size];
        }
    }
}