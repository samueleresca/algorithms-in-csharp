using System.Collections.Generic;
using System.Linq;
using Shouldly;
using Xunit;

namespace HandsOn.Algorithms.Top10
{
    public class DispenserFuelProblemTests
    {

        [Fact]
        public void should_return_the_right_waiting_time()
        {
            var queue = new int[] { 2, 8, 4, 3, 2 };
            var result = new DispenserFuelProblem().solution(queue, 7, 11, 3);

            result.ShouldBe(8);
        }

        [Fact]
        public void should_return_the_right_waiting_time_2()
        {
            var queue = new int[] { 5 };
            var result = new DispenserFuelProblem().solution(queue, 4, 0, 3);

            result.ShouldBe(-1);
        }

        [Fact]
        public void should_return_the_right_waiting_time_3()
        {
            var queue = new int[] { 2, 8, 4, 3, 2, 2, 8, 4, 3, 2, 2, 8, 4, 3, 2, 2, 999999, 4, 3, 2, 2, 8, 4, 3, 2, 2, 10, 4, 3, 2, 2, 8, 4, 3, 2, 2, 8, 4, 3, };
            var result = new DispenserFuelProblem().solution(queue, 5, 99999999, 3);

            result.ShouldBe(8);
        }
    }
}