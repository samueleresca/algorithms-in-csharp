using Shouldly;
using Xunit;

namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public class CompareVersionNumbersTests
    {
        [Theory]
        [InlineData("0.1", "1.1", -1)]
        [InlineData("1.0.1", "1", 1)]
        [InlineData("7.5.2.4", "7.5.3", -1)]
        [InlineData("1.01", "1.001", 0)]
        public void should_compare_versions_correctly(string version1, string version2, int result)
        {
            CompareVersionNumbers.CompareVersion(version1, version2).ShouldBe(result);
        }
    }
}