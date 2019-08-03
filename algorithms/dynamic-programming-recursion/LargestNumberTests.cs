using Shouldly;
using Xunit;

namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public class LargestNumberTests
    {

        [Fact]
        public void should_calc_the_right_number()
        {
            LargestNumber.Calc(new[] { 10, 2 }).ShouldBe("210");
        }

        [Fact]
        public void should_calc_the_right_number_2()
        {
            LargestNumber.Calc(new[] { 3, 30, 34, 5, 9 }).ShouldBe("9534330");
        }

        [Fact]
        public void should_calc_the_right_number_3()
        {
            LargestNumber.Calc(new[] { 999999998, 999999997, 999999999 }).ShouldBe("999999999999999998999999997");
        }

        [Fact]
        public void should_calc_the_right_number_4()
        {
            LargestNumber.Calc(new[] { 0, 0 }).ShouldBe("0");
        }
    }
}