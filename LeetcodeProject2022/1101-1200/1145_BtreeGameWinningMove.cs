using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1101_1200
{
    public class _1145_BtreeGameWinningMove
    {//抢位置思路，如果我在前面走能比对手的其他两条快，则胜利，否则无法胜利
        int m_count;
        public bool BtreeGameWinningMove(TreeNode root, int n, int x)
        {
            m_count = 0;
            if (root.val == x)
            {
                TryVisit(root.left);
                int max = m_count;
                m_count = 0;
                TryVisit(root.right);
                max = Math.Max(max, m_count);
                return max > n / 2;
            }
            else
            {
                TreeNode cur = Find(root, x);
                if (cur == null)
                {
                    return false;
                }
                TryVisit(cur);
                int max = n - m_count;
                if (cur.left != null)
                {
                    m_count = 0;
                    TryVisit(cur.left);
                    max = Math.Max(max, m_count);
                }
                if (cur.right != null)
                {
                    m_count = 0;
                    TryVisit(cur.right);
                    max = Math.Max(max, m_count);
                }
                return max > n / 2;
            }
        }

        void TryVisit(TreeNode root)
        {
            m_count++;
            if (root.left != null)
            {
                TryVisit(root.left);
            }
            if (root.right != null)
            {
                TryVisit(root.right);
            }
        }
        TreeNode Find(TreeNode root, int val)
        {
            if (root.val == val)
            {
                return root;
            }
            TreeNode res = null;
            if (root.left != null)
            {
                res = Find(root.left, val);
            }
            if (res != null)
            {
                return res;
            }
            if (root.right != null)
            {
                res = Find(root.right, val);
            }
            return res;
        }
    }
}
