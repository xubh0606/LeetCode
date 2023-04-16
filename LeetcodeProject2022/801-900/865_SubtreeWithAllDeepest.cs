using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._801_900
{
    public class _865_SubtreeWithAllDeepest
    {
        public TreeNode SubtreeWithAllDeepest(TreeNode root)
        {
            TreeNode new_root = FindMostDeep(root);
            return FindSmallestSubtree(root, new_root);
        }

        TreeNode FindMostDeep(TreeNode root)
        {
            if (root.left == null && root.right == null)
            {
                return new TreeNode(1);
            }
            TreeNode curNode = new TreeNode();
            int curDeep = 0;
            if (root.left != null)
            {
                curNode.left = FindMostDeep(root.left);
                curDeep = Math.Max(curDeep, curNode.left.val + 1);
            }
            if (root.right != null)
            {
                curNode.right = FindMostDeep(root.right);
                curDeep = Math.Max(curDeep, curNode.right.val + 1);
            }
            curNode.val = curDeep;
            return curNode;
        }

        TreeNode FindSmallestSubtree(TreeNode root, TreeNode new_root)
        {
            if (new_root.left == null && new_root.right == null)
            {
                return root;
            }
            if (new_root.left == null)
            {
                return FindSmallestSubtree(root.right, new_root.right);
            }
            if (new_root.right == null)
            {
                return FindSmallestSubtree(root.left, new_root.left);
            }
            int left = new_root.left.val;
            int right = new_root.right.val;
            if (left == right)
            {
                return root;
            }
            if (left > right)
            {
                return FindSmallestSubtree(root.left, new_root.left);
            }
            return FindSmallestSubtree(root.right, new_root.right);
        }
    }
}
