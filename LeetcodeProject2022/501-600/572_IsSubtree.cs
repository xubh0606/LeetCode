using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600
{
    public class _572_IsSubtree
    {
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (Cheak(root, subRoot))
            {
                return true;
            }
            if (root.left != null)
            {
                if (IsSubtree(root.left, subRoot))
                {
                    return true;
                }
            }
            if (root.right != null)
            {
                if (IsSubtree(root.right, subRoot))
                {
                    return true;
                }
            }
            return false;
        }
        bool Cheak(TreeNode root, TreeNode subRoot)
        {
            if (root == null && subRoot == null)
            {
                return true;
            }
            if (root == null || subRoot == null)
            {
                return false;
            }
            if (root.val != subRoot.val)
            {
                return false;
            }
            return Cheak(root.left, subRoot.left) && Cheak(root.right, subRoot.right);
        }
    }
}
