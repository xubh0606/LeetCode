using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _111_MinDepth
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            if (root.left == null && root.right == null)
            {
                return 1;
            }
            if (root.left == null)
            {
                return MinDepth(root.right) + 1;
            }
            if (root.right == null)
            {
                return MinDepth(root.left) + 1;
            }
            return Math.Min(MinDepth(root.right), MinDepth(root.left)) + 1;
        }
    }
}
