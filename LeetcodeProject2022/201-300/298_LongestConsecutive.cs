using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _298_LongestConsecutive
    {
        int maxCount = 1;
        public int LongestConsecutive(TreeNode root)
        {
            dfs(root, 1);
            return maxCount;
        }

        void dfs(TreeNode root, int count)
        {
            if (root.left == null && root.right == null)
            {
                if (count > maxCount)
                {
                    maxCount = count;
                }
                return;
            }
            if (root.left != null)
            {
                if (root.left.val == root.val + 1)
                {
                    dfs(root.left, count + 1);
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                    dfs(root.left, 1);
                }
            }
            if (root.right != null)
            {
                if (root.right.val == root.val + 1)
                {
                    dfs(root.right, count + 1);
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                    dfs(root.right, 1);
                }
            }
        }
    }
}
