using Xunit;

namespace HandsOn.Algorithm.DynamicProgrammingRecursion
{
    public class FrequentIntegerArrayTests
    {


        [Fact]

        public void should_perform_the_right_operation()
        {
            var result = FrequentIntegerArray.TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 2);
        }

    }
}