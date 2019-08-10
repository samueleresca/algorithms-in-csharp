namespace HandsOn.Algorithm.TreesGraphs
{
    public static class PreOrderTraversal
    {
        public static void ExecutePreOrder(TreeNode node)
        {
            if (node == null) return;

            var getValue = node.val;
            ExecutePreOrder(node.left);
            ExecutePreOrder(node.right);
        }
    }
}