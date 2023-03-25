using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetcodeProject2022;

namespace LeetcodeProject2022._1_100
{
    public class _94_InorderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> res = new List<int>();
            inorder(root, res);
            return res;
        }
        void inorder(TreeNode root, IList<int> res)
        {
            if (root == null)
            {
                return;
            }
            inorder(root.left, res);
            res.Add(root.val);
            inorder(root.right, res);
            return;
        }
    }
}
