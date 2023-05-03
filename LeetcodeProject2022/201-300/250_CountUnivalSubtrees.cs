using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _250_CountUnivalSubtrees
    {
        int res = 0;
        public int CountUnivalSubtrees(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            isUnivalSubtrees(root);
            return res;
        }
        bool isUnivalSubtrees(TreeNode root)
        {
            if (root.left == null && root.right == null)
            {
                res++;
                return true;
            }
            if (root.left != null)
            {
                bool left = isUnivalSubtrees(root.left);
                if (root.right != null)
                {
                    bool right = isUnivalSubtrees(root.right);
                    if (!right || !left)
                    {
                        return false;
                    }
                    if (root.val != root.right.val || root.val != root.left.val)
                    {
                        return false;
                    }
                    res++;
                    return true;
                }
                else
                {
                    if (!left)
                    {
                        return false;
                    }
                    if (root.val != root.left.val)
                    {
                        return false;
                    }
                    res++;
                    return true;
                }
            }
            else
            {
                bool right = isUnivalSubtrees(root.right);
                if (!right)
                {
                    return false;
                }
                if (root.val != root.right.val)
                {
                    return false;
                }
                res++;
                return true;
            }
        }
    }
}
