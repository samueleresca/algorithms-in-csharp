namespace HandsOn.Algorithms.ArraysAndStrings
{
    public class GetInOrderSuccessor
    {
        public TreeNode GetSuccessor(TreeNode root, TreeNode p)
        {
            TreeNode target = null;
            bst(root, p.val, ref target);
            return target;
        }

        public void bst(TreeNode root, int targetValue, ref TreeNode lastValue)
        {
            if (root == null) return;


            if (targetValue < root.val)
            {
                if (lastValue == null) lastValue = root;

                if (root.val < lastValue.val) lastValue = root;
            }

            bst(root.left, targetValue, ref lastValue);
            bst(root.right, targetValue, ref lastValue);
        }
    }


    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int val;

        public TreeNode(int x)
        {
            val = x;
        }
    }
}