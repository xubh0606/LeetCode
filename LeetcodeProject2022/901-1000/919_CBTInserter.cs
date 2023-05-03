using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._901_1000
{
    public class _919_CBTInserter
    {
        private TreeNode m_root;
        private Queue<TreeNode> m_nodeQueue;
        private TreeNode m_parent;
        private int m_curCount;
        private int m_totalCount;

        public _919_CBTInserter(TreeNode root)
        {
            m_root = root;
            m_parent = null;
            m_nodeQueue = new Queue<TreeNode>();
            m_nodeQueue.Enqueue(m_root);
            m_totalCount = 1;
            while (m_totalCount > 0)
            {
                while (m_curCount != m_totalCount)
                {
                    TreeNode cur_node = m_nodeQueue.Dequeue();
                    if (cur_node.left != null && cur_node.right != null)
                    {
                        m_nodeQueue.Enqueue(cur_node.left);
                        m_nodeQueue.Enqueue(cur_node.right);
                        m_curCount++;
                    }
                    else
                    {
                        m_parent = cur_node;
                        if (m_parent.left != null)
                        {
                            m_nodeQueue.Enqueue(m_parent.left);
                        }
                        return;
                    }
                }
                m_totalCount = m_totalCount * 2;
            }
        }

        public int Insert(int val)
        {
            TreeNode new_node = new TreeNode(val);
            int p_val = m_parent.val;
            m_nodeQueue.Enqueue(new_node);
            if (m_parent.left == null)
            {
                m_parent.left = new_node;
            }
            else
            {
                m_parent.right = new_node;
                m_parent = m_nodeQueue.Dequeue();
                m_curCount++;
                if (m_curCount == m_totalCount)
                {
                    m_curCount = 0;
                    m_totalCount *= 2;
                }
            }
            return p_val;
        }

        public TreeNode Get_root()
        {
            return m_root;
        }
    }
}
