using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _366_FindLeaves
    {
        public IList<IList<int>> FindLeaves(TreeNode root)
        {
            IList<IList<int>> LeavesList = new List<IList<int>>();
            if (root == null)
            {
                return LeavesList;
            }
            FindDeepth(LeavesList, root);
            return LeavesList;
        }
        int FindDeepth(IList<IList<int>> LeavesList, TreeNode root)
        {
            int maxDeep = 0;
            if (root.left != null)
            {
                maxDeep = Math.Max(maxDeep, FindDeepth(LeavesList, root.left) + 1);
            }
            if (root.right != null)
            {
                maxDeep = Math.Max(maxDeep, FindDeepth(LeavesList, root.right) + 1);
            }
            if (LeavesList.Count <= maxDeep)
            {
                LeavesList.Add(new List<int>());
            }
            LeavesList[maxDeep].Add(root.val);
            return maxDeep;
        }
    }
}
