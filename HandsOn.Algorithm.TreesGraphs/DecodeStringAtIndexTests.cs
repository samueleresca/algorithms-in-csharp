using Shouldly;
using Xunit;

namespace HandsOn.Algorithm.TreesGraphs
{
    public class DecodeStringAtIndexTests
    {


        [Fact]
        public void should_perform_the_right_operation()
        {
            var result = DecodeStringAtIndex.DecodeString("a2345678999999999999999", 1);
            result.ShouldBe("a");
        }

        [Fact]
        public void should_perform_the_right_operation_2()
        {
            var result = DecodeStringAtIndex.DecodeString("leet2code3", 10);
            result.ShouldBe("o");
        }

        [Fact]
        public void should_perform_the_right_operation_3()
        {
            var result = DecodeStringAtIndex.DecodeString("a23", 6);
            result.ShouldBe("a");
        }

        [Fact]
        public void should_perform_the_right_operation_4()
        {
            var result = DecodeStringAtIndex.DecodeString("ha22", 5);
            result.ShouldBe("h");
        }

        [Fact]
        public void should_perform_the_right_operation_5()
        {
            var result = DecodeStringAtIndex.DecodeString("a2b3c4d5e6f7g8h9", 69280);
            result.ShouldBe("a");
        }

    }
}