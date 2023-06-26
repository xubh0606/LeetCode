using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _235_LowestCommonAncestor
    {
        TreeNode m_res;
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            GetLCA(root, p, q);
            return m_res;
        }
        bool[] GetLCA(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return new bool[2];
            }
            bool[] cheak = GetLCA(root.left, p, q);
            bool[] rightCheak = GetLCA(root.right, p, q);
            cheak[0] = cheak[0] || rightCheak[0];
            cheak[1] = cheak[1] || rightCheak[1];
            if (root == p)
            {
                cheak[0] = true;
            }
            if (root == q)
            {
                cheak[1] = true;
            }
            if (cheak[0] && cheak[1])
            {
                cheak = new bool[2];
                m_res = root;
            }
            return cheak;
        }
    }
}
