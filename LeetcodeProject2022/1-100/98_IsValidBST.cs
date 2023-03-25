using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._1_100
{
    public class _98_IsValidBST
    {
        public bool IsValidBST(TreeNode root)
        {
            int[] res = CheakValidBST(root);
            return res[0] == 0;
        }
        int[] CheakValidBST(TreeNode root)
        {
            int[] cur_cheak = new int[3];
            cur_cheak[1] = root.val;
            cur_cheak[2] = root.val;
            if (root.left == null && root.right == null)
            {
                return cur_cheak;
            }
            if (root.left != null)
            {
                int[] left_cheak = CheakValidBST(root.left);
                if (left_cheak[0] == 1 || left_cheak[2] >= root.val)
                {
                    cur_cheak[0] = 1;
                    return cur_cheak;
                }
                cur_cheak[1] = left_cheak[1];
            }
            if (root.right != null)
            {
                int[] right_cheak = CheakValidBST(root.right);
                if (right_cheak[0] == 1 || right_cheak[1] <= root.val)
                {
                    cur_cheak[0] = 1;
                    return cur_cheak;
                }
                cur_cheak[2] = right_cheak[2];
            }
            return cur_cheak;
        }
    }
}
