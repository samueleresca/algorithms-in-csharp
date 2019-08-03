using System.Security.Cryptography;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class WordGridTest
    {
        [Theory]
        [InlineData("ABCCED", true)]
        [InlineData("SEE", true)]
        [InlineData("ABCB", false)]
        public void should_return_right_word(string word, bool result)
        {
            var board = new char[3][];


            board[0] = new[] { 'A', 'B', 'C', 'E' };
            board[1] = new[] { 'S', 'F', 'C', 'S' };
            board[2] = new[] { 'A', 'D', 'E', 'E' };

            new WordGrid().Exist(board, word).ShouldBe(result);
        }
    }
}