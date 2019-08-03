using Shouldly;
using Xunit;

namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public class FindMaxNumberOfSquaresTests
    {
        [Theory]
        [InlineData(10, 20, 2)]
        [InlineData(6000, 7000, 3)]
        public void checkResult(int numA, int numB, int result)
        {
            FindMaxNumberOfSquares.NumSquares(numA, numB).ShouldBe(result);
        }
    }
}