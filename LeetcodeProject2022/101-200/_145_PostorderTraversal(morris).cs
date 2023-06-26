using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._101_200
{
    public class _145_PostorderTraversal_morris_
    {
        //使用morris遍历二叉树
        public IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> res = new List<int>();
            if (root == null)
            {
                return res;
            }
            TreeNode cur = root;
            TreeNode mostRight = null;
            while (cur != null)
            {
                mostRight = cur.left;
                if (mostRight != null)
                {
                    while (mostRight.right != null && mostRight.right != cur)
                    {
                        mostRight = mostRight.right;
                    }
                    if (mostRight == null)
                    {
                        mostRight.right = cur;
                        cur = cur.left;
                        continue;
                    }
                    else
                    {
                        mostRight.right = null;
                        AddReverse(res, cur.left);
                    }
                }
                cur = cur.right;
            }
            AddReverse(res, root);
            return res;
        }
        void AddReverse(IList<int> res, TreeNode cur)
        {
            TreeNode tail = Reverse(cur);
            TreeNode head = tail;
            while (head != null)
            {
                res.Add(head.val);
                head = head.right;
            }
            Reverse(tail);
        }
        TreeNode Reverse(TreeNode cur)
        {
            TreeNode head = null;
            TreeNode dummy_head = null;
            while (cur != null)
            {
                dummy_head = cur.right;
                cur.right = head;
                head = cur;
                cur = dummy_head;
            }
            return head;
        }
    }
}
