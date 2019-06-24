using System;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace HandsOn.Algorithms.ArraysAndStrings.DynamicProgramming
{
    public static class JumpGameII
    {
           public static int calculateSteps(int[] stepsPath)
           {
               var i = 1;

               if (stepsPath.Length == 1)
               {
                   return 0;
               }

               while (i < stepsPath.Length)
               {
                   var stepLength = stepsPath[i];
                   
                   if (i + stepLength == stepsPath.Length)
                   {
                       return i;
                   }

                   i++;
               }

               return i;
           } 
    }
}