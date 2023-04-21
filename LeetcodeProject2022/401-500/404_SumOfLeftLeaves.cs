using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._401_500
{
    public class _404_SumOfLeftLeaves
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null || (root.left == null && root.right == null))
            {
                return 0;
            }
            int leftSum = 0;
            int rightSum = 0;
            if (root.left != null)
            {
                if (root.left.left == null && root.left.right == null)
                {
                    leftSum = root.left.val + SumOfLeftLeaves(root.left);
                }
                else
                {
                    leftSum = SumOfLeftLeaves(root.left);
                }
            }
            if (root.right != null)
            {
                rightSum = SumOfLeftLeaves(root.right);
            }
            return leftSum + rightSum;
        }
    }
}
