namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public static class CompareVersionNumbers
    {
        public static int CompareVersion(string version1, string version2)
        {

            var splittedVersion1 = version1.Split('.');
            var splittedVersion2 = version2.Split('.');

            for (int i = 0; i < splittedVersion1.Length || i < splittedVersion2.Length; i++)
            {
                int v1i = splittedVersion1.Length > i ? int.Parse(splittedVersion1[i]) : 0;
                int v2i = splittedVersion2.Length > i ? int.Parse(splittedVersion2[i]) : 0;

                if (v1i > v2i)
                {
                    return 1;
                }
                if (v1i < v2i)
                {
                    return -1;
                }
            }

            return 0;
        }
    }
}