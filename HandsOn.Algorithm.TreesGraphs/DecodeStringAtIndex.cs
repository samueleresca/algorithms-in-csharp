using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using Microsoft.VisualStudio.TestPlatform.CoreUtilities.Extensions;

namespace HandsOn.Algorithm.TreesGraphs
{
    public static class DecodeStringAtIndex
    {

        public static string DecodeString(string S, int K)
        {
            var dictionary = new Dictionary<int, int>();

            for (var index = 0; index < S.ToCharArray().Length; index++)
            {
                if (!Char.IsNumber(S.ToCharArray()[index])) continue;
                var character = int.Parse(S.ToCharArray()[index].ToString());

                dictionary.Add(index, character);
            }

            foreach (var test in dictionary.Values)
            {
                S = S.Replace(test.ToString(), "");
            }

            for (var index = 0; index <= S.ToCharArray().Length && S.ToCharArray().Length < K; index++)
            {
                if (!dictionary.ContainsKey(index)) continue;

                var repeatedCount = dictionary[index];
                var repetableValue = S.Substring(0, index);
                var otherString = S.Substring(index, S.Length - index);

                repetableValue = string.Concat(Enumerable.Repeat(repetableValue, repeatedCount));

                S = repetableValue + otherString;
            }

            try
            {
                return S.Substring(K - 1, 1);

            }
            catch
            {
                return string.Empty;
            }

        }
    }
}