namespace HandsOn.Algorithm.TreesGraphs
{
    public class PostOrderTraversal
    {
        public static void ExecutePostOrder(TreeNode node)
        {
            if (node == null) return;

            ExecutePostOrder(node.left);
            ExecutePostOrder(node.right);
            var getValue = node.val;
        }
    }
}