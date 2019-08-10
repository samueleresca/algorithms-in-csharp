using System.Collections.Generic;

namespace HandsOn.Algorithm.TreesGraphs
{
    public class BinarySearchTraversal
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var myList = new List<int>();
            if (root == null) return myList;

            PostOrderHandler(root, myList);
            return myList;
        }

        private void PostOrderHandler(TreeNode root, List<int> myList)
        {
            if (root == null) return;

            PostOrderHandler(root.left, myList);
            PostOrderHandler(root.right, myList);

            myList.Add(root.val);
        }
    }
}