using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _270_ClosestValue
    {
        public int ClosestValue(TreeNode root, double target)
        {
            if (root.left == null && root.right == null)
            {
                return root.val;
            }
            int center = root.val;
            if (root.left != null)
            {
                int left = ClosestValue(root.left, target);
                if (root.left.val >= target)
                {
                    return left;
                }
                else if (root.left.val < target && center >= target)
                {
                    if (compare(left, center, target))
                    {
                        return center;
                    }
                    else
                    {
                        return left;
                    }
                }
            }
            else
            {
                if (target <= center)
                {
                    return center;
                }
            }
            if (root.right != null)
            {
                int right = ClosestValue(root.right, target);
                if (root.right.val < target)
                {
                    return right;
                }
                else if (root.right.val > target && center < target)
                {
                    if (compare(center, right, target))
                    {
                        return right;
                    }
                    return center;
                }
            }
            else
            {
                if (target > center)
                {
                    return center;
                }
            }
            return center;
        }
        bool compare(int i, int j, double target)
        {
            double ii = target - i;
            double jj = j - target;
            if (ii > jj)
            {
                return true;
            }
            return false;
        }
    }
}
