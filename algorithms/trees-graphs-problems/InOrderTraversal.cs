namespace HandsOn.Algorithm.TreesGraphs
{
    public static class InOrderTraversal
    {
        public static void ExecuteInOrder(TreeNode node)
        {
            if (node == null) return;

            ExecuteInOrder(node.left);
            var getValue = node.val;
            ExecuteInOrder(node.right);
        }
    }
}