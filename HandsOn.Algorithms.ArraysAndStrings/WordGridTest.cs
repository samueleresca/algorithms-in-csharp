using System.Security.Cryptography;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class WordGridTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public WordGridTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void should_return_right_word()
        {
            var board = new char[3][];


            board[0] = new char[] { 'A', 'B', 'C', 'E' };
            board[1] = new char[] { 'S', 'F', 'C', 'S' };
            board[2] = new char[] { 'A', 'D', 'E', 'E' };

            new WordGrid().Exist(board, "ABCCED", _testOutputHelper).ShouldBe(true);
        }

    }
}