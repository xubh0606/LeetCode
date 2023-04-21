using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject2022._501_600
{
    public class _513_FindBottomLeftValue
    {
        public int FindBottomLeftValue(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            int res = 0;
            q.Enqueue(root);
            while (q.Count != 0)
            {
                TreeNode t = q.Dequeue();
                res = t.val;
                if (t.left != null)
                {
                    q.Enqueue(t.left);
                }
                if (t.right != null)
                {
                    q.Enqueue(t.right);
                }
                int c = q.Count;
                for (int i = 1; i < c; i++)
                {
                    t = q.Dequeue();
                    if (t.left != null)
                    {
                        q.Enqueue(t.left);
                    }
                    if (t.right != null)
                    {
                        q.Enqueue(t.right);
                    }
                }
            }
            return res;
        }
    }
}
