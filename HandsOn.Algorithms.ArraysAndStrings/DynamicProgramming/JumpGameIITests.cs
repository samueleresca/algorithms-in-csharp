using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using Shouldly;
using Xunit;

namespace HandsOn.Algorithms.ArraysAndStrings.DynamicProgramming
{
    public  class JumpGameIITests
    {
        [Fact]
        public static void should_calculate_the_right_steps()
        {
            int[] steps = new int[]{ 2,3,1,1,4}; 
            JumpGameII.calculateSteps(steps).ShouldBe(2);
        }
        
        [Fact]
        public static void should_calculate_the_right_empty()
        {
            int[] steps = new int[]{0}; 
            JumpGameII.calculateSteps(steps).ShouldBe(0);
        }
    }
}