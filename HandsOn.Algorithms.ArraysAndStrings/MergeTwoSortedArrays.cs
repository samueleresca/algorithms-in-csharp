using System;
using System.Linq;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class MergeTwoSortedArrays
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // two get pointers for nums1 and nums2
            int p1 = m - 1;
            int p2 = n - 1;
            // set pointer for nums1
            int p = m + n - 1;

            // while there are still elements to compare
            while ((p1 >= 0) && (p2 >= 0))
                // compare two elements from nums1 and nums2 
                // and add the largest one in nums1 
                nums1[p--] = (nums1[p1] < nums2[p2]) ? nums2[p2--] : nums1[p1--];

            // add missing elements from nums2
            Array.Copy(nums2, 0, nums1, 0, p2 + 1);
        }
    }
}