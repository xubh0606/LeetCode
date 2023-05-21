using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _104_MaxDepth
    {
        public int MaxDepth(TreeNode root)
        {
            return FindMaxDepth(root);
        }
        int FindMaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return Math.Max(FindMaxDepth(root.left), FindMaxDepth(root.right)) + 1;
        }
    }
}
