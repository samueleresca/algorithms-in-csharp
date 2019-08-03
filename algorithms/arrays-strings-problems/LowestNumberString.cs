
namespace HandsOn.Algorithms.ArraysAndStrings
{
    public static class LowestNumberString
    {
        public static string RemoveKdigits(string num, int k)
        {
            var result = "";
            buildLowestNumberRec(num, k, ref result);

            if (result.StartsWith("0"))
            {
                result = result.Substring(1, result.Length - 1);
            }

            return result == "" ? "0" : result;
        }


        static void buildLowestNumberRec(string str, int n, ref string result)
        {
            // If there are 0 characters to remove from str, 
            // append everything to result 
            if (n == 0)
            {

                result = result + str;
                return;
            }

            int len = str.Length;

            // If there are more characters to remove than string 
            // length, then append nothing to result 
            if (len <= n)
                return;

            // Find the smallest character among first (n+1) characters 
            // of str. 
            int minIndex = 0;
            for (int i = 1; i <= n; i++)
                if (str[i] < str[minIndex])
                    minIndex = i;

            // Append the smallest character to result 

            if (str[minIndex] == '0' && result == string.Empty)
            {
                result += "";
            }
            else
            {
                result += str[minIndex];
            }



            // substring starting from minIndex+1 to str.length() - 1. 
            string new_str = str.Substring(minIndex + 1, len - minIndex - 1);

            // Recur for the above substring and n equals to n-minIndex 
            buildLowestNumberRec(new_str, n - minIndex, ref result);
        }

    }
}