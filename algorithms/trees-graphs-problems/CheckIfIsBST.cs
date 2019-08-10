namespace HandsOn.Algorithm.TreesGraphs
{
    // C# implementation to check if given Binary tree 
    //is a BST or not 

    /* Class containing left and right child of current 
    node and key value*/
    public class BinaryTree
    {
        //Root of the Binary Tree 
        public TreeNode root;

        /* can give min and max value according to your code or 
        can write a function to find min and max value of tree. */

        /* returns true if given search tree is binary 
        search tree (efficient version) */
        public virtual bool BST => isBSTUtil(root, int.MinValue, int.MaxValue);

        /* Returns true if the given tree is a BST and its 
        values are >= min and <= max. */
        public virtual bool isBSTUtil(TreeNode node, int min, int max)
        {
            /* an empty tree is BST */
            if (node == null) return true;

            /* false if this node violates the min/max constraints */
            if (node.val < min || node.val > max) return false;

            /* otherwise check the subtrees recursively 
            tightening the min/max constraints */
            // Allow only distinct values 
            return isBSTUtil(node.left, min, node.val - 1) && isBSTUtil(node.right, node.val + 1, max);
        }
    }

    public class Solution
    {
        public bool helper(TreeNode node, int? lower, int? upper)
        {
            if (node == null) return true;

            var val = node.val;
            if (lower != null && val <= lower) return false;
            if (upper != null && val >= upper) return false;

            if (!helper(node.right, val, upper)) return false;
            if (!helper(node.left, lower, val)) return false;
            return true;
        }

        public bool isValidBST(TreeNode root)
        {
            return helper(root, null, null);
        }
    }
}