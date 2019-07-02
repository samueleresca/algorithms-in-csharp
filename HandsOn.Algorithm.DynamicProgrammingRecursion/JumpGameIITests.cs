using Shouldly;
using Xunit;

namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public class JumpGameIITests
    {
        [Fact]
        public static void should_calculate_the_right_steps()
        {
            int[] steps = { 2, 3, 1, 1, 4 };
            JumpGameII.calculateSteps(steps).ShouldBe(2);
        }

        [Fact]
        public static void should_calculate_the_right_empty()
        {
            int[] steps = new int[] { 0 };
            JumpGameII.calculateSteps(steps).ShouldBe(0);
        }


        [Fact]
        public static void should_calculate_the_right_steps_2()
        {
            int[] steps = { 1, 2, 3 };
            JumpGameII.calculateSteps(steps).ShouldBe(2);
        }

        [Fact]
        public static void should_calculate_the_right_steps_3()
        {
            int[] steps = { 1, 2 };
            JumpGameII.calculateSteps(steps).ShouldBe(1);
        }




    }
}