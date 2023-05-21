using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _110_IsBalanced
    {
        public bool IsBalanced(TreeNode root)
        {
            return CheakBalance(root) >= 0;
        }
        int CheakBalance(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int l = CheakBalance(root.left);
            int r = CheakBalance(root.right);
            if (l == -1 || r == -1 || Math.Abs(l - r) > 1)
            {
                return -1;
            }
            return Math.Max(l, r) + 1;
        }
    }
}
