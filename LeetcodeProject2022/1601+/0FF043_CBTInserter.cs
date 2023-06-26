using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class _0FF043_CBTInserter
    {//提前拟定下一个节点位置（父节点）
        TreeNode m_root;
        Queue<TreeNode> m_fatherSet;
        public _0FF043_CBTInserter(TreeNode root)
        {
            m_root = root;
            m_fatherSet = new Queue<TreeNode>();
            if (root != null)
            {
                m_fatherSet.Enqueue(root);
                while (true)
                {
                    TreeNode cur_root = m_fatherSet.Peek();
                    if (cur_root.left == null || cur_root.right == null)
                    {
                        if (cur_root.left != null)
                        {
                            m_fatherSet.Enqueue(cur_root.left);
                        }
                        break;
                    }
                    m_fatherSet.Enqueue(cur_root.left);
                    m_fatherSet.Enqueue(cur_root.right);
                    m_fatherSet.Dequeue();
                }
            }
        }

        public int Insert(int v)
        {
            TreeNode cur_root = m_fatherSet.Peek();
            if (cur_root.left == null)
            {
                cur_root.left = new TreeNode(v);
                m_fatherSet.Enqueue(cur_root.left);
            }
            else
            {
                cur_root.right = new TreeNode(v);
                m_fatherSet.Enqueue(cur_root.right);
                m_fatherSet.Dequeue();
            }
            return cur_root.val;
        }

        public TreeNode Get_root()
        {
            return m_root;
        }
    }

    /**
     * Your CBTInserter object will be instantiated and called as such:
     * CBTInserter obj = new CBTInserter(root);
     * int param_1 = obj.Insert(v);
     * TreeNode param_2 = obj.Get_root();
     */
}
