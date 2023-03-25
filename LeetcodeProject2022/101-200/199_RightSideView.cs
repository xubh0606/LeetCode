using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _199_RightSideView
    {
        IList<int> m_res;
        int m_level;
        public IList<int> RightSideView(TreeNode root)
        {
            m_res = new List<int>();
            if (root == null)
            {
                return m_res;
            }
            m_res.Add(root.val);
            FindEachLevel(root, 1);
            return m_res;
        }
        void FindEachLevel(TreeNode root, int level)
        {
            if (root.right != null)
            {
                if (level > m_level)
                {
                    m_level++;
                    m_res.Add(root.right.val);
                }
                FindEachLevel(root.right, level + 1);
            }
            if (root.left != null)
            {
                if (level > m_level)
                {
                    m_level++;
                    m_res.Add(root.left.val);
                }
                FindEachLevel(root.left, level + 1);
            }
        }
    }
}
