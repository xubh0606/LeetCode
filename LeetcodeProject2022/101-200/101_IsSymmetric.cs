using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _101_IsSymmetric
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            return LeftAsRight(root.left, root.right);
        }
        bool LeftAsRight(TreeNode leftTree, TreeNode rightTree)
        {
            if (leftTree == null && rightTree == null)
            {
                return true;
            }
            if (leftTree == null || rightTree == null)
            {
                return false;
            }
            if (leftTree.val != rightTree.val)
            {
                return false;
            }
            return LeftAsRight(leftTree.left, rightTree.right) && LeftAsRight(leftTree.right, rightTree.left);
        }
    }
}
