using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._201_300
{
    public class _285_InorderSuccessor
    {
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            if (root == null)
            {
                return null;
            }
            TreeNode res = InorderSuccessor(root.left, p);
            if (res != null)
            {
                return res;
            }
            if (root.val > p.val)
            {
                return root;
            }
            return InorderSuccessor(root.right, p);
        }
    }
}
