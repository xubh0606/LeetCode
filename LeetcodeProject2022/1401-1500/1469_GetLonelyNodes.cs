using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1401_1500
{
    public class _1469_GetLonelyNodes
    {
        IList<int> m_res;
        public IList<int> GetLonelyNodes(TreeNode root)
        {
            m_res = new List<int>();
            FindAllLonelyNode(root);
            return m_res;
        }
        void FindAllLonelyNode(TreeNode root)
        {
            TreeNode l = root.left;
            TreeNode r = root.right;
            if (root.left != null && root.right != null)
            {
                FindAllLonelyNode(l);
                FindAllLonelyNode(r);
            }
            else if (root.left != null)
            {
                m_res.Add(l.val);
                FindAllLonelyNode(l);
            }
            else if (root.right != null)
            {
                m_res.Add(r.val);
                FindAllLonelyNode(r);
            }
        }
    }
}
