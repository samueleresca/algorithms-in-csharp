
namespace HandsOn.Algorithm.TreesGraphs
{
    public static class MinimalTree
    {
        public static TreeNode Create(int[] array)
        {
            return Create(array, 0, array.Length - 1);
        }

        private static TreeNode Create(int[] arr, int start, int end)
        {
            if (end < start)
            {
                return null;
            }
            int mid = (start + end) / 2;
            var node = new TreeNode(arr[mid])
            {
                left = Create(arr, start, mid - 1),
                right = Create(arr, mid + 1, end)
            };

            return node;
        }
    }
}