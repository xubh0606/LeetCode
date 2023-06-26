using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _230_KthSmallest
    {
        int m_target;
        public int KthSmallest(TreeNode root, int k)
        {
            m_target = 0;
            FindK(root, k, 0);
            return m_target;
        }
        int FindK(TreeNode root, int k, int visitedCount)
        {
            if (root.left != null)
            {
                visitedCount = FindK(root.left, k, visitedCount);
            }
            if (visitedCount >= k)
            {
                return int.MaxValue;
            }
            visitedCount++;
            if (visitedCount == k)
            {
                m_target = root.val;
                return int.MaxValue;
            }
            if (root.right != null)
            {
                visitedCount = FindK(root.right, k, visitedCount);
            }
            return visitedCount;
        }
    }
}
