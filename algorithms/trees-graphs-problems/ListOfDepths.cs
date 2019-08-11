using System.Collections.Generic;

namespace HandsOn.Algorithm.TreesGraphs
{
    public class ListOfDepths
    {

        public IList<IList<int>> Execute(TreeNode root)
        {
            IList<IList<int>> levelList = new List<IList<int>>();
            recursiveOrder(levelList, root, 0);
            return levelList;
        }

        private void recursiveOrder(IList<IList<int>> list, TreeNode node, int level)
        {
            if (node == null)
            {
                return;
            }

            if (list.Count == level)
                list.Add(new List<int>());

            if (list[level] == null)
                list.Add(new List<int>(node.val));
            else
                list[level].Add(node.val);

            level = level + 1;
            recursiveOrder(list, node.left, level);
            recursiveOrder(list, node.right, level);
        }
    }
}