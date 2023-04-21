using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._301_400
{
    public class _333_LargestBSTSubtree
    {
        int ans;
        public int LargestBSTSubtree(TreeNode root)
        {
            isBST(root);
            return ans;
        }
        int[] isBST(TreeNode root)
        {
            if (root == null)
            {
                return new int[] { int.MaxValue, int.MinValue, 0, 1 };
            }
            int[] left = isBST(root.left);
            int[] right = isBST(root.right);
            // 最小值
            int min = Math.Min(root.val, Math.Min(left[0], right[0]));
            // 最大值
            int max = Math.Max(root.val, Math.Max(left[1], right[1]));
            // 节点个数
            int count = left[2] + right[2] + 1;
            // 是否是bst (0 不是 1 是)
            int flag = (left[3] == right[3] && left[3] == 1 && root.val > left[1] && root.val < right[0]) ? 1 : 0;
            // 更新最大bst
            if (flag == 1) ans = Math.Max(ans, count);
            return new int[] { min, max, count, flag };
        }
    }
}
