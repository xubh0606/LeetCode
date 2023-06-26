using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1601_
{
    public class OFF054_ConvertBST
    {
        //考虑使用morris遍历，但是需要修改进入方向为先右后左
        int m_rightVal;
        //等同于纵向遍历，可以按照中序遍历的逆序得出结论并输出
        public TreeNode ConvertBST(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            TreeNode cur = root;
            m_rightVal = 0;
            while (cur != null)
            {
                TreeNode mostLeft = cur.right;
                if (mostLeft != null)
                {
                    while (mostLeft.left != null && mostLeft.left != cur)
                    {
                        mostLeft = mostLeft.left;
                    }
                    if (mostLeft.left == null)
                    {
                        mostLeft.left = cur;
                        cur = cur.right;
                        continue;
                    }
                    else
                    {
                        mostLeft.left = null;
                    }
                }
                m_rightVal += cur.val;
                cur.val = m_rightVal;
                cur = cur.left;
            }
            return root;
        }
    }
}
