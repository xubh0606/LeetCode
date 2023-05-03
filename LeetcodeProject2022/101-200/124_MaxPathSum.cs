using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _124_MaxPathSum
    {
        int m_Maxsum;
        public int MaxPathSum(TreeNode root)
        {
            m_Maxsum = int.MinValue;
            getMaxSum(root);
            return m_Maxsum;
        }
        int getMaxSum(TreeNode root)
        {
            int left = 0;
            int right = 0;
            int val = root.val;
            if (root.left != null)
            {
                left = getMaxSum(root.left);
            }
            if (root.right != null)
            {
                right = getMaxSum(root.right);
            }
            m_Maxsum = Math.Max(m_Maxsum, val + right + left);
            val = Math.Max(left, right) + val;
            return Math.Max(val, 0);
        }
    }
}
