using Shouldly;
using Xunit;

namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public class FindMaxNumberOfSquaresTests
    {

        [Fact]
        public void checkResult()
        {
            FindMaxNumberOfSquares.NumSquares(10, 20).ShouldBe(2);
        }

        [Fact]
        public void checkResult_1()
        {
            FindMaxNumberOfSquares.NumSquares(6000, 7000).ShouldBe(3);
        }

    }
}