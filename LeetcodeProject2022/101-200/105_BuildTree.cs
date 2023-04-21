using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _105_BuildTree
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            int length = preorder.Length;
            for (int i = 0; i < length; i++)
            {
                dic.Add(inorder[i], i);
            }
            return Build(preorder, inorder, 0, length - 1, 0, length - 1);
        }
        TreeNode Build(int[] preorder, int[] inorder, int leftp, int rightp, int lefti, int righti)
        {
            if (leftp > rightp)
            {
                return null;
            }
            int val = preorder[leftp];
            int center = dic[val];
            int leftCount = center - lefti;
            int rightCount = righti - center;
            TreeNode root = new TreeNode(val);
            if (lefti < center)
            {
                root.left = Build(preorder, inorder, leftp + 1, leftp + leftCount, lefti, center - 1);
            }
            if (center < righti)
            {
                root.right = Build(preorder, inorder, leftp + leftCount + 1, leftp + leftCount + rightCount, center + 1, righti);
            }
            return root;
        }
    }
}
