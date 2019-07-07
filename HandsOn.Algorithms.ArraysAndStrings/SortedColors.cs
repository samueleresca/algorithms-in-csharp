using System.Collections.Concurrent;
using Xunit.Sdk;

namespace HandsOn.Algorithms.ArraysAndStrings
{
    public static class SortedColors
    {

        public static void GetSortedColors(int[] nums)
        {
            QuickSort(nums, 0, nums.Length - 1);
        }

        private static void QuickSort(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex) return;

            int pivot = Partition(arr, leftIndex, rightIndex);

            if (pivot > 1)
            {
                QuickSort(arr, leftIndex, pivot - 1);
            }
            if (pivot + 1 < rightIndex)
            {
                QuickSort(arr, pivot + 1, rightIndex);
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot) left++;
                while (arr[right] > pivot) right--;


                if (left < right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;

                    if (arr[left] == arr[right])
                        left++;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}