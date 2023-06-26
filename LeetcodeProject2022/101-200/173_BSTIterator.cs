using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _173_BSTIterator
    {
        Stack<TreeNode> m_iteratorStack;
        int m_lastNum = -1;
        public _173_BSTIterator(TreeNode root)
        {
            m_iteratorStack = new Stack<TreeNode>();
            while (root != null)
            {
                m_iteratorStack.Push(root);
                root = root.left;
            }
        }

        public int Next()
        {
            //额外考虑next调用错误情况
            if (m_iteratorStack.Count > 0)
            {
                TreeNode cur_node = m_iteratorStack.Pop();
                if (cur_node.right != null)
                {
                    TreeNode next_node = cur_node.right;
                    while (next_node != null)
                    {
                        m_iteratorStack.Push(next_node);
                        next_node = next_node.left;
                    }
                }
                else
                {
                    while (m_iteratorStack.Count != 0 && m_iteratorStack.Peek().val < m_lastNum)
                    {
                        m_iteratorStack.Pop();
                    }
                }
                m_lastNum = cur_node.val;
                return m_lastNum;
            }
            else
            {
                return -1;
            }
        }

        public bool HasNext()
        {
            return m_iteratorStack.Count != 0;
        }
    }
}
