using Shouldly;
using Xunit;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class ShortestPathInMatrixTests
    {

        [Fact]
        public void should_return_the_right_shortest_path()
        {
            var board = new int[2][];

            board[0] = new[] { 0, 1 };
            board[1] = new[] { 1, 0 };

            new ShortestPathInMatrix().ShortestPathBinaryMatrix(board).ShouldBe(2);
        }

        [Fact]
        public void should_return_the_right_shortest_path_2()
        {
            var board = new int[3][];

            board[0] = new[] { 0, 0, 0 };
            board[1] = new[] { 1, 1, 0 };
            board[2] = new[] { 1, 1, 0 };

            new ShortestPathInMatrix().ShortestPathBinaryMatrix(board).ShouldBe(4);
        }
    }
}