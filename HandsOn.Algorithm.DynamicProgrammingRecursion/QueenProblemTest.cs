using Shouldly;
using Xunit;

namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public class QueenProblemTest
    {

        [Fact]
        public void should_return_right_result()
        {
           var result = new QueenProblem().SolveNQueens(4);
          result.Count.ShouldBe(2);
            
        }

    }
}