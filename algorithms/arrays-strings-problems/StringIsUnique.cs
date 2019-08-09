using System.Collections.Generic;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public static class StringIsUnique
    {
        public static bool Execute(string s)
        {
            if (s.Length > 128) return false; //(ASCII)
            var charDictionary = new Dictionary<char, bool>();

            foreach (var currentElement in s)
            {
                if (charDictionary.ContainsKey(currentElement)) return false;
                charDictionary.Add(currentElement, true);
            }

            return true;
        }
    }
}