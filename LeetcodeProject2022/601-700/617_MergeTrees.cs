using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._601_700
{
    public class _617_MergeTrees
    {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null)
            {
                return root2;
            }
            if (root2 == null)
            {
                return root1;
            }
            Queue<TreeNode> q1 = new Queue<TreeNode>();
            Queue<TreeNode> q2 = new Queue<TreeNode>();
            q1.Enqueue(root1);
            q2.Enqueue(root2);
            while (q1.Count != 0)
            {
                int count = q1.Count;
                for (int i = 0; i < count; i++)
                {
                    TreeNode dq1 = q1.Dequeue();
                    TreeNode dq2 = q2.Dequeue();
                    dq1.val += dq2.val;
                    if (dq1.left != null && dq2.left != null)
                    {
                        q1.Enqueue(dq1.left);
                        q2.Enqueue(dq2.left);
                    }
                    else if (dq2.left != null)
                    {
                        dq1.left = dq2.left;
                    }
                    if (dq1.right != null && dq2.right != null)
                    {
                        q1.Enqueue(dq1.right);
                        q2.Enqueue(dq2.right);
                    }
                    else if (dq2.right != null)
                    {
                        dq1.right = dq2.right;
                    }
                }
            }
            return root1;
        }
    }
}
